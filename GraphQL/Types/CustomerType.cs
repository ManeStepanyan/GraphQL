using GraphQL.DataLoader;
using GraphQL.Extensions;
using HotChocolate;
using HotChocolate.Types;
using Microsoft.EntityFrameworkCore;
using NorthwindTest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GraphQL.Types
{
    public class CustomerType : ObjectType<Customers>
    {
        protected override void Configure(IObjectTypeDescriptor<Customers> descriptor)
        {
            descriptor
                .Field(t => t.Orders)
                .ResolveWith<SpeakerResolvers>(t => t.GetOrdersAsync(default!, default!, default!, default))
                .UseDbContext<ApplicationDbContext>()
                .Name("orders");
        }

        private class SpeakerResolvers
        {
            public async Task<IEnumerable<Orders>> GetOrdersAsync(
                Customers customer,
                [ScopedService] ApplicationDbContext dbContext,
                OrderByIdDataLoader orderById,
                CancellationToken cancellationToken)
            {
                int[] orderIds = await dbContext.Customers
                    .Where(s => s.Id == customer.Id)
                    .Include(s => s.Orders)
                    .SelectMany(s => s.Orders.Select(t => t.Id))
                    .ToArrayAsync();

                return await orderById.LoadAsync(orderIds, cancellationToken);
            }
        }
    }
    }

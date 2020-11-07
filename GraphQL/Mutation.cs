using GraphQL.Data;
using GraphQL.Extensions;
using HotChocolate;
using HotChocolate.Subscriptions;
using NorthwindTest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL
{
    public class Mutation
    {
        [UseApplicationDbContext]
        public async Task<AddCustomerPayload> AddCustomerAsync(AddCustomerInput input, [ScopedService] ApplicationDbContext context, [Service] ITopicEventSender eventSender)
        {
            var customer = new Customers
            {
                Id = input.Id,
                LastName = input.Surname
            };
            context.Customers.Add(customer);
            await context.SaveChangesAsync();
            await eventSender.SendAsync(nameof(CustomerSubscriptions.OnCustomerCreationAsync), customer.Id);
            return new AddCustomerPayload(customer);
        }
    }
}

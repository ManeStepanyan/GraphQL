using GraphQL.Data;
using HotChocolate;
using NorthwindTest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL
{
    public class Mutation
    {
        public async Task<AddCustomerPayload> AddCustomerAsync(AddCustomerInput input, [Service] ApplicationDbContext context)
        {
            var customer = new Customers
            {
                Id = input.Id,
                LastName = input.Surname
            };
            context.Customers.Add(customer);
            await context.SaveChangesAsync();
            return new AddCustomerPayload(customer);
        }
    }
}

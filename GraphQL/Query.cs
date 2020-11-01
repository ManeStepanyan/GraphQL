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

namespace GraphQL
{
    /// <summary>
    /// Query root type
    /// </summary>
    public class Query
    { 
        [UseApplicationDbContext] // applying a Middleware to the field resolver pipeline
        public Task<List<Customers>> GetCustomers([ScopedService] ApplicationDbContext context) => context.Customers.ToListAsync();
        public async Task<Customers> GetCustomerByIdAsync(int id, CustomerByIdDataLoader dataLoader, CancellationToken cancellationToken) => await dataLoader.LoadAsync(id, cancellationToken);
    }
}

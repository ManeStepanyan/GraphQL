using GreenDonut;
using HotChocolate.DataLoader;
using Microsoft.EntityFrameworkCore;
using NorthwindTest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GraphQL.DataLoader
{
    public class CustomerByIdDataLoader : BatchDataLoader<int, Customers>
    {
        private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;
        public CustomerByIdDataLoader(IBatchScheduler batchScheduler, IDbContextFactory<ApplicationDbContext> dbContextFactory) : base(batchScheduler)
        {
            _dbContextFactory = dbContextFactory ??
                 throw new ArgumentNullException(nameof(dbContextFactory));
        }
        protected override async Task<IReadOnlyDictionary<int, Customers>> LoadBatchAsync(IReadOnlyList<int> keys, CancellationToken cancellationToken)
        {
            await using ApplicationDbContext dbContext =_dbContextFactory.CreateDbContext();
            return await dbContext.Customers
                .Where(c => keys.Contains(c.Id))
                .ToDictionaryAsync(t => t.Id, cancellationToken);
        }
    }
}

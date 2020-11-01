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
    public class OrderByIdDataLoader : BatchDataLoader<int, Orders>
    {
        private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;

        public OrderByIdDataLoader(
            IBatchScheduler batchScheduler,
            IDbContextFactory<ApplicationDbContext> dbContextFactory)
            : base(batchScheduler)
        {
            _dbContextFactory = dbContextFactory ??
                throw new ArgumentNullException(nameof(dbContextFactory));
        }

        protected override async Task<IReadOnlyDictionary<int, Orders>> LoadBatchAsync(
            IReadOnlyList<int> keys,
            CancellationToken cancellationToken)
        {
            await using ApplicationDbContext dbContext =
                _dbContextFactory.CreateDbContext();

            return await dbContext.Orders
                .Where(s => keys.Contains(s.Id))
                .ToDictionaryAsync(t => t.Id, cancellationToken);
        }
    }
}

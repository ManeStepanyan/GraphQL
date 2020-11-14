using IdentityServer4.EntityFramework.DbContexts;
using IdentityServer4.EntityFramework.Options;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public class PersistedGrantDbContextFactory : PersistedGrantDbContext<PersistedGrantDbContext>
    {
        public PersistedGrantDbContextFactory(DbContextOptions options, OperationalStoreOptions storeOptions) : base(options, storeOptions)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

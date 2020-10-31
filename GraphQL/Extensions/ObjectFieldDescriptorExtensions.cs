using HotChocolate.Types;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.Extensions
{
    public static class ObjectFieldDescriptorExtensions
    {
        /// <summary>
        /// The UseDbContext will create a new middleware that handles scoping for a field. 
        /// The create part will rent from the pool a DBContext, the dispose part will return it after the middleware is finished. 
        /// All of this is handled transparently through the new IDbContextFactory<T> introduced with .NET 5.
        /// </summary>
        /// <typeparam name="TDbContext"></typeparam>
        /// <param name="descriptor"></param>
        /// <returns></returns>
        public static IObjectFieldDescriptor UseDbContext<TDbContext>(
            this IObjectFieldDescriptor descriptor)
            where TDbContext : DbContext
        {
            return descriptor.UseScopedService<TDbContext>(
                create: s => s.GetRequiredService<IDbContextFactory<TDbContext>>().CreateDbContext(),
                disposeAsync: (s, c) => c.DisposeAsync());
        }
    }
}

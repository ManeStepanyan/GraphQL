using HotChocolate;
using NorthwindTest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
/// <summary>
/// Query root type
/// </summary>
    public class Query
    {
        public IQueryable<Customers> GetCustomers([Service] ApplicationDbContext context) => context.Customers;
    }
}

using NorthwindTest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.Data
{
    public class AddCustomerPayload
    {
        public Customers Customer { get; }
        public AddCustomerPayload(Customers customer)
        {
            Customer = customer;
        }
    }
}

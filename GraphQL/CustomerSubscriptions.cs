using GraphQL.DataLoader;
using HotChocolate;
using HotChocolate.Types;
using NorthwindTest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GraphQL
{
    public class CustomerSubscriptions
    {
        [Subscribe]
        [Topic]
        public Task<Customers> OnCustomerCreationAsync(
            [EventMessage] int customerId,
            CustomerByIdDataLoader customerById,
            CancellationToken cancellationToken) =>
            customerById.LoadAsync(customerId, cancellationToken);
    }
}

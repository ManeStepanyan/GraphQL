using System;
using System.Collections.Generic;

#nullable disable

namespace Infrastructure
{
    public partial class Employee
    {
        public Employee()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }
        public string JobTitle { get; set; }
        public string Department { get; set; }
        public int? ManagerId { get; set; }
        public string Phone { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}

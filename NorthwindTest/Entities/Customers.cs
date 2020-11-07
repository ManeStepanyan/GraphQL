using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthwindTest.Entities
{
    [Table("customers")]
    public partial class Customers
    {
        public Customers()
        {
            Orders = new HashSet<Orders>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("last_name")]
        [StringLength(50)]
        public string? LastName { get; set; }
        [Column("first_name")]
        [StringLength(50)]
        public string? FirstName { get; set; }
        [Column("email")]
        [StringLength(50)]
        public string? Email { get; set; }
        [Column("company")]
        [StringLength(50)]
        public string? Company { get; set; }
        [Column("phone")]
        [StringLength(25)]
        public string? Phone { get; set; }
        [Column("address1")]
        [StringLength(150)]
        public string? Address1 { get; set; }
        [Column("address2")]
        [StringLength(150)]
        public string? Address2 { get; set; }
        [Column("city")]
        [StringLength(50)]
        public string? City { get; set; }
        [Column("state")]
        [StringLength(50)]
        public string? State { get; set; }
        [Column("postal_code")]
        [StringLength(15)]
        public string? PostalCode { get; set; }
        [Column("country")]
        [StringLength(50)]
        public string? Country { get; set; }

        [InverseProperty("Customer")]
        public virtual ICollection<Orders>? Orders { get; set; }
    }
}

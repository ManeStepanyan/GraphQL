using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthwindTest.Entities
{
    [Table("orders")]
    public partial class Orders
    {
        public Orders()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("employee_id")]
        public int? EmployeeId { get; set; }
        [Column("customer_id")]
        public int? CustomerId { get; set; }
        [Column("order_date", TypeName = "datetime")]
        public DateTime? OrderDate { get; set; }
        [Column("shipped_date", TypeName = "datetime")]
        public DateTime? ShippedDate { get; set; }
        [Column("ship_name")]
        [StringLength(50)]
        public string? ShipName { get; set; }
        [Column("ship_address1")]
        [StringLength(150)]
        public string? ShipAddress1 { get; set; }
        [Column("ship_address2")]
        [StringLength(150)]
        public string? ShipAddress2 { get; set; }
        [Column("ship_city")]
        [StringLength(50)]
        public string? ShipCity { get; set; }
        [Column("ship_state")]
        [StringLength(50)]
        public string? ShipState { get; set; }
        [Column("ship_postal_code")]
        [StringLength(50)]
        public string? ShipPostalCode { get; set; }
        [Column("ship_country")]
        [StringLength(50)]
        public string? ShipCountry { get; set; }
        [Column("shipping_fee", TypeName = "decimal(19, 4)")]
        public decimal? ShippingFee { get; set; }
        [Column("payment_type")]
        [StringLength(50)]
        public string? PaymentType { get; set; }
        [Column("paid_date", TypeName = "datetime")]
        public DateTime? PaidDate { get; set; }
        [Column("order_status")]
        [StringLength(25)]
        public string? OrderStatus { get; set; }

        [ForeignKey(nameof(CustomerId))]
        [InverseProperty(nameof(Customers.Orders))]
        public virtual Customers? Customer { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        [InverseProperty(nameof(Employees.Orders))]
        public virtual Employees? Employee { get; set; }
        [InverseProperty("Order")]
        public virtual ICollection<OrderDetails>? OrderDetails { get; set; }
    }
}

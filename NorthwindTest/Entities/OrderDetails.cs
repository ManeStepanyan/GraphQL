using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthwindTest.Entities
{
    [Table("order_details")]
    public partial class OrderDetails
    {
        [Key]
        [Column("order_id")]
        public int OrderId { get; set; }
        [Key]
        [Column("product_id")]
        public int ProductId { get; set; }
        [Column("quantity", TypeName = "decimal(18, 4)")]
        public decimal Quantity { get; set; }
        [Column("unit_price", TypeName = "decimal(19, 4)")]
        public decimal? UnitPrice { get; set; }
        [Column("discount")]
        public double Discount { get; set; }
        [Column("order_detail_status")]
        [StringLength(25)]
        public string OrderDetailStatus { get; set; }
        [Column("date_allocated", TypeName = "datetime")]
        public DateTime? DateAllocated { get; set; }

        [ForeignKey(nameof(OrderId))]
        [InverseProperty(nameof(Orders.OrderDetails))]
        public virtual Orders Order { get; set; }
        [ForeignKey(nameof(ProductId))]
        [InverseProperty(nameof(Products.OrderDetails))]
        public virtual Products Product { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthwindTest.Entities
{
    [Table("products")]
    public partial class Products
    {
        public Products()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("product_code")]
        [StringLength(25)]
        public string? ProductCode { get; set; }
        [Column("product_name")]
        [StringLength(50)]
        public string? ProductName { get; set; }
        [Column("description")]
        [StringLength(250)]
        public string? Description { get; set; }
        [Column("standard_cost", TypeName = "decimal(19, 4)")]
        public decimal? StandardCost { get; set; }
        [Column("list_price", TypeName = "decimal(19, 4)")]
        public decimal ListPrice { get; set; }
        [Column("target_level")]
        public int? TargetLevel { get; set; }
        [Column("reorder_level")]
        public int? ReorderLevel { get; set; }
        [Column("minimum_reorder_quantity")]
        public int? MinimumReorderQuantity { get; set; }
        [Column("quantity_per_unit")]
        [StringLength(50)]
        public string? QuantityPerUnit { get; set; }
        [Column("discontinued")]
        public byte Discontinued { get; set; }
        [Column("category")]
        [StringLength(50)]
        public string? Category { get; set; }

        [InverseProperty("Product")]
        public virtual ICollection<OrderDetails>? OrderDetails { get; set; }
    }
}

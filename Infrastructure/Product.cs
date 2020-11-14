using System;
using System.Collections.Generic;

#nullable disable

namespace Infrastructure
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal? StandardCost { get; set; }
        public decimal ListPrice { get; set; }
        public int? TargetLevel { get; set; }
        public int? ReorderLevel { get; set; }
        public int? MinimumReorderQuantity { get; set; }
        public string QuantityPerUnit { get; set; }
        public byte Discontinued { get; set; }
        public string Category { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}

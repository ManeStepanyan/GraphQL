using System;
using System.Collections.Generic;

#nullable disable

namespace Infrastructure
{
    public partial class OrderDetail
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public double Discount { get; set; }
        public string OrderDetailStatus { get; set; }
        public DateTime? DateAllocated { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}

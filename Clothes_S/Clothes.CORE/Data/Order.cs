using System;
using System.Collections.Generic;

namespace Clothes.CORE.Data
{
    public partial class Order
    {
        public decimal Orderid { get; set; }
        public DateTime? Orderdate { get; set; }
        public string? Status { get; set; }
        public decimal? Totalamount { get; set; }
        public decimal? Userid { get; set; }
        public decimal? CartId { get; set; }
        public string? Ordercode { get; set; }

        public virtual Cart? Cart { get; set; }
        public virtual User? User { get; set; }
    }
}

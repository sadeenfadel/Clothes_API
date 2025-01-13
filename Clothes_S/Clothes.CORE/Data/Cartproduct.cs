using System;
using System.Collections.Generic;

namespace Clothes.CORE.Data
{
    public partial class Cartproduct
    {
        public decimal Cartproductid { get; set; }
        public decimal? CartId { get; set; }
        public decimal? ProductId { get; set; }
        public decimal? Quantity { get; set; }

        public virtual Cart? Cart { get; set; }
        public virtual Product? Product { get; set; }
    }
}

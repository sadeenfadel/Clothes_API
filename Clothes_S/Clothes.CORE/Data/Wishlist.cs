using System;
using System.Collections.Generic;

namespace Clothes.CORE.Data
{
    public partial class Wishlist
    {
        public decimal Wishlistid { get; set; }
        public DateTime? Createdat { get; set; }
        public decimal? Userid { get; set; }
        public decimal? Productid { get; set; }

        public virtual Product? Product { get; set; }
        public virtual User? User { get; set; }
    }
}

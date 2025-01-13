using System;
using System.Collections.Generic;

namespace Clothes.CORE.Data
{
    public partial class Review
    {
        public decimal Reviewid { get; set; }
        public string? UserComment { get; set; }
        public string? Status { get; set; }
        public decimal? Rating { get; set; }
        public decimal? Productid { get; set; }
        public decimal? Userid { get; set; }

        public virtual Product? Product { get; set; }
        public virtual User? User { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Clothes.CORE.Data
{
    public partial class Address
    {
        public decimal Id { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? Postcode { get; set; }
        public decimal? Userid { get; set; }

        public virtual User? User { get; set; }
    }
}

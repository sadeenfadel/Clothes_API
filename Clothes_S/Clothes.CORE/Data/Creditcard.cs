using System;
using System.Collections.Generic;

namespace Clothes.CORE.Data
{
    public partial class Creditcard
    {
        public decimal Id { get; set; }
        public decimal? Userid { get; set; }
        public decimal? Cardnumber { get; set; }
        public string? Cardholdername { get; set; }
        public decimal? Cvv { get; set; }
        public DateTime? Expirydate { get; set; }
        public decimal Balance { get; set; }

        public virtual User? User { get; set; }
    }
}

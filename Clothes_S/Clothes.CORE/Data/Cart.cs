using System;
using System.Collections.Generic;

namespace Clothes.CORE.Data
{
    public partial class Cart
    {
        public Cart()
        {
            Cartproducts = new HashSet<Cartproduct>();
            Orders = new HashSet<Order>();
            Products = new HashSet<Product>();
        }

        public decimal Cartid { get; set; }
        public DateTime? Createdat { get; set; }
        public decimal? Userid { get; set; }

        public virtual User? User { get; set; }
        public virtual ICollection<Cartproduct> Cartproducts { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}

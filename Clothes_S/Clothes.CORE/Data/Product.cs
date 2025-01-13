using System;
using System.Collections.Generic;

namespace Clothes.CORE.Data
{
    public partial class Product
    {
        public Product()
        {
            Cartproducts = new HashSet<Cartproduct>();
            Reviews = new HashSet<Review>();
            Wishlists = new HashSet<Wishlist>();
        }

        public decimal Productid { get; set; }
        public string? Name { get; set; }
        public decimal? Price { get; set; }
        public string? ProductSize { get; set; }
        public string? Color { get; set; }
        public decimal? Stock { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }
        public decimal? Categoryid { get; set; }
        public decimal? Poid { get; set; }
        public decimal? CartId { get; set; }

        public virtual Cart? Cart { get; set; }
        public virtual Category? Category { get; set; }
        public virtual Productowner? Po { get; set; }
        public virtual ICollection<Cartproduct> Cartproducts { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Wishlist> Wishlists { get; set; }
    }
}

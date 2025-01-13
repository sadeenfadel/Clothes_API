using System;
using System.Collections.Generic;

namespace Clothes.CORE.Data
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public decimal Catid { get; set; }
        public string? Name { get; set; }
        public string? Image { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}

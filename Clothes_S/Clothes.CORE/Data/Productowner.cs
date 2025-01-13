using System;
using System.Collections.Generic;

namespace Clothes.CORE.Data
{
    public partial class Productowner
    {
        public Productowner()
        {
            Logins = new HashSet<Login>();
            Products = new HashSet<Product>();
        }

        public decimal Id { get; set; }
        public string? Storename { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public string? Logo { get; set; }
        public string? Phonenumber { get; set; }
        public string? Address { get; set; }
        public string? Status { get; set; }

        public virtual ICollection<Login> Logins { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}

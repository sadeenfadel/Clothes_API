using System;
using System.Collections.Generic;

namespace Clothes.CORE.Data
{
    public partial class Login
    {
        public decimal Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public decimal? Userid { get; set; }
        public decimal? Roleid { get; set; }
        public decimal? Productownerid { get; set; }

        public virtual Productowner? Productowner { get; set; }
        public virtual Role? Role { get; set; }
        public virtual User? User { get; set; }
    }
}

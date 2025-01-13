using System;
using System.Collections.Generic;

namespace Clothes.CORE.Data
{
    public partial class Role
    {
        public Role()
        {
            Logins = new HashSet<Login>();
        }

        public decimal Id { get; set; }
        public string? Rolename { get; set; }

        public virtual ICollection<Login> Logins { get; set; }
    }
}

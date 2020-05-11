using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAZModa.Models
{
    public class StyleShop
    {
        public int Id { get; set; }
        public int StyleId { get; set; }
        public int ShopId { get; set; }

        public virtual Shop Shop { get; set; }
        public virtual Style Style { get; set; }
    }
}

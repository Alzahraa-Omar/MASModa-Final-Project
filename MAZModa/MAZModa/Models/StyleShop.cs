using System;
using System.Collections.Generic;

namespace MAZModa.Models
{
    public partial class StyleShop
    {
        public int Id { get; set; }
        public int? StyleId { get; set; }
        public int? ShopId { get; set; }

        public virtual Shop Shop { get; set; }
        public virtual Style Style { get; set; }
    }
}

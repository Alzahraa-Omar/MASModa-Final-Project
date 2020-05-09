using System;
using System.Collections.Generic;

namespace MAZModa.Models
{
    public partial class Shop
    {
        public Shop()
        {
            StyleShop = new HashSet<StyleShop>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public virtual ICollection<StyleShop> StyleShop { get; set; }
    }
}

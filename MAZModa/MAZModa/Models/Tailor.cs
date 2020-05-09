using System;
using System.Collections.Generic;

namespace MAZModa.Models
{
    public partial class Tailor
    {
        public Tailor()
        {
            TailorPhoto = new HashSet<TailorPhoto>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int? Rate { get; set; }

        public virtual ICollection<TailorPhoto> TailorPhoto { get; set; }
    }
}

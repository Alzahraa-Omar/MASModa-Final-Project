using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAZModa.Models
{
    public class Tailor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int Rate { get; set; }

        public virtual ICollection<TailorPhoto> TailorPhoto { get; set; }
    }
}

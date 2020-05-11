using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAZModa.Models
{
    public class DressCode
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Style> Style { get; set; }
    }
}

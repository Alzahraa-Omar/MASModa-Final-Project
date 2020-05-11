using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAZModa.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string PhotoPath { get; set; }
        public int StyleId { get; set; }

        public virtual Style Style { get; set; }
    }
}

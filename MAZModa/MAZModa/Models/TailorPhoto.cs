using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAZModa.Models
{
    public class TailorPhoto
    {
        public int Id { get; set; }
        public string PhotoPath { get; set; }
        public int TailorId { get; set; }

        public virtual Tailor Tailor { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAZModa.Models
{
    public class Heights
    {
        public int Id { get; set; }
        public string BetweenHeight { get; set; }

        public virtual ICollection<Style> Style { get; set; }
    }
}

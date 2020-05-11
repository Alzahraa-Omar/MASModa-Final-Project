using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAZModa.Models
{
    public class Age
    {
        public int Id { get; set; }
        public string BetweenAge { get; set; }

        public virtual ICollection<Style> Style { get; set; }
    }
}

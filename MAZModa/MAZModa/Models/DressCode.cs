using System;
using System.Collections.Generic;

namespace MAZModa.Models
{
    public partial class DressCode
    {
        public DressCode()
        {
            Style = new HashSet<Style>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Style> Style { get; set; }
    }
}

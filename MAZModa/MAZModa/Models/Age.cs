using System;
using System.Collections.Generic;

namespace MAZModa.Models
{
    public partial class Age
    {
        public Age()
        {
            Style = new HashSet<Style>();
        }

        public int Id { get; set; }
        public string BetweenAge { get; set; }

        public virtual ICollection<Style> Style { get; set; }
    }
}

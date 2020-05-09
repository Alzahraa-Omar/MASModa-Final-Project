using System;
using System.Collections.Generic;

namespace MAZModa.Models
{
    public partial class Heights
    {
        public Heights()
        {
            Style = new HashSet<Style>();
        }

        public int Id { get; set; }
        public string BetweenHeight { get; set; }

        public virtual ICollection<Style> Style { get; set; }
    }
}

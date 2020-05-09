using System;
using System.Collections.Generic;

namespace MAZModa.Models
{
    public partial class Weights
    {
        public Weights()
        {
            Style = new HashSet<Style>();
        }

        public int Id { get; set; }
        public string BetweenWeight { get; set; }

        public virtual ICollection<Style> Style { get; set; }
    }
}

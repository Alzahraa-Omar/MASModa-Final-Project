using System;
using System.Collections.Generic;

namespace MAZModa.Models
{
    public partial class Photo
    {
        public int Id { get; set; }
        public string PhotoPath { get; set; }
        public int? StyleId { get; set; }

        public virtual Style Style { get; set; }
    }
}

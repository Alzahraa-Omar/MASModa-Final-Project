using System;
using System.Collections.Generic;

namespace MAZModa.Models
{
    public partial class TailorPhoto
    {
        public int Id { get; set; }
        public string PhotoPath { get; set; }
        public int? TailorId { get; set; }

        public virtual Tailor Tailor { get; set; }
    }
}

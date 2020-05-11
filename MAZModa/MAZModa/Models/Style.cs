using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAZModa.Models
{
    public class Style
    {
        public int Id { get; set; }
        public string StyleDescription { get; set; }
        public int GenderId { get; set; }
        public int CategoryId { get; set; }
        public int DressCodeId { get; set; }
        public int WeightId { get; set; }
        public int HeightId { get; set; }
        public int AgeId { get; set; }

        public virtual Gender Gender { get; set; }
        public virtual Age Age { get; set; }
        public virtual Category Category { get; set; }
        public virtual DressCode DressCode { get; set; }
        public virtual Heights Height { get; set; }
        public virtual Weights Weight { get; set; }
        public virtual ICollection<Photo> Photo { get; set; }
        public virtual ICollection<StyleShop> StyleShop { get; set; }
    }
}

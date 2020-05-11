using MAZModa.Data;
using MAZModa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAZModa
{
    public class MAZModaFunctions
    {
        MAZModaDbContext context = new MAZModaDbContext();

        public void DataForm()
        { 
        }
        public ICollection<Style> RecommendStyle(int _GenderId, int _CategoryId, int _AgeId, int _DressCodeId, int _WeihgtId, int _HeightId)
        {
            ICollection<Style> RecommendedStyles = context.Style.Where(s => s.GenderId == _GenderId && s.CategoryId == _CategoryId
            && s.AgeId == _AgeId && s.DressCodeId == _DressCodeId && s.WeightId == _WeihgtId && s.HeightId == _HeightId).ToList();
            return RecommendedStyles;
        }
        public ICollection<ICollection<Photo>> GetPhotos()
        {
            ICollection<Style> RStyles;
            ICollection<ICollection<Photo>> SelectedPhotosLists = null;
            foreach (var CurrentStyle in RStyles)
            {
                ICollection<Photo> TempListPhoto = context.Photo.Where(ph => ph.StyleId == CurrentStyle.Id).ToList();
                SelectedPhotosLists.Add(TempListPhoto);
            }
            return SelectedPhotosLists;
        }
    }
}

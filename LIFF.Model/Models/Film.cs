using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIFF.Model
{
    public class Film
    {
        public int FilmId { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public string TrailerURL { get; set; }
        public int RunningTime { get; set; }
        public bool Subtitles { get; set; }

        //Foreign keys
        public List<int> DirectorID { get; set; }
        public List<int> CountryID { get; set; }

        //Navigation properties
        public virtual List<Director> Director { get; set; }
        public virtual List<Country> Country { get; set; }
        public virtual List<TimeSlot> Slots { get; set; }
        public virtual List<Venue> Venues { get; set; }
        public virtual List<ImagePath> Images { get; set; }


    }
}

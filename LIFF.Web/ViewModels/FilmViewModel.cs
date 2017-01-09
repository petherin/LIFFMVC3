using LIFF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LIFF.Web.ViewModels
{
    public class FilmViewModel
    {
        public int FilmId { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public string TrailerURL { get; set; }
        public int RunningTime { get; set; }
        public bool Subtitles { get; set; }
        public string Certificate { get; set; }

        //Foreign keys
        //public List<int> DirectorID { get; set; }
        //public List<int> CountryID { get; set; }

        //Navigation properties
        public virtual List<DirectorViewModel> Director { get; set; }
        public virtual List<CountryViewModel> Country { get; set; }
        public virtual List<TimeSlotViewModel> Slots { get; set; }
        public virtual List<VenueViewModel> Venues { get; set; }
        public virtual List<ImagePathViewModel> Images { get; set; }
    }
}
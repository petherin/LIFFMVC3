using LIFF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LIFF.Web.ViewModels
{
    public class TimeSlotViewModel
    {
        public int TimeSlotId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool Selected { get; set; }

        //Foreign keys
        public int FilmID { get; set; }
        public int VenueID { get; set; }

        //Navigation properties
        public virtual FilmViewModel Film { get; set; }
        public virtual VenueViewModel Venue { get; set; }
    }
}
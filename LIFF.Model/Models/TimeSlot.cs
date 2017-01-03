using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIFF.Model
{
    public class TimeSlot
    {
        public int TimeSlotId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool Selected { get; set; }

        //Foreign keys
        public int FilmID { get; set; }
        public int VenueID { get; set; }

        //Navigation properties
        public virtual Film Film { get; set; }
        public virtual Venue Venue { get; set; }

    }
}

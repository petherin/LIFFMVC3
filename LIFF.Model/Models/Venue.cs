using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIFF.Model
{
    public class Venue
    {
        public int VenueId { get; set; }
        public string Name { get; set; }

        //Navigation properties
        public virtual List<TimeSlot> Slots { get; set; }
     //   public virtual List<Film> Films { get; set; }
    }
}

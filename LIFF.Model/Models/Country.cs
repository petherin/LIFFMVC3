using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIFF.Model
{
    public class Country
    {
        public int CountryId { get; set; }
        public string Name { get; set; }

        //Navigation properties
        public virtual List<Film> Films { get; set; }
    }
}

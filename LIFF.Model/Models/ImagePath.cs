using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIFF.Model
{
    public class ImagePath
    {
        public int ImagePathId { get; set; }
        public string Path { get; set; }

        //Navigation properties
        public virtual List<Film> Films { get; set; }
    }
}

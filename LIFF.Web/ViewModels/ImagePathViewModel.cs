using LIFF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LIFF.Web.ViewModels
{
    public class ImagePathViewModel
    {
        public int ImagePathId { get; set; }
        public string Path { get; set; }

        //Navigation properties
      //  public virtual List<FilmViewModel> Films { get; set; }
    }
}
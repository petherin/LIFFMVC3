using LIFF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LIFF.Web.ViewModels
{
    public class CountryViewModel
    {
        public int CountryId { get; set; }
        public string Name { get; set; }

        ////Navigation properties
        public virtual List<FilmViewModel> Films { get; set; }
    }
}
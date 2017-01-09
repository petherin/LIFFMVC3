using LIFF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LIFF.Web.ViewModels
{
    public class NewsItemViewModel
    {
        public int NewsItemId { get; set; }
        public string Headline { get; set; }
        public DateTime DatePosted { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
        public List<ImagePath> Images { get; set; }
    }
}
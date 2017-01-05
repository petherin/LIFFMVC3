using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace LIFF.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bootstrap/js").Include("~/js/bootstrap.js", "~/js/site.js"));
            bundles.Add(new StyleBundle("~/bootstrap/css").Include("~/css/bootstrap.css", "~/js/site.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
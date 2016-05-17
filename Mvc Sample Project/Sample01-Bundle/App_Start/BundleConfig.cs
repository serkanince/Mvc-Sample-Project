using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Sample01_Bundle.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/Css").Include(
                "~/assets/bootstrap-{version}.css"));

            bundles.Add(new ScriptBundle("~/bundles/JS").Include(
                "~/assets/jquery-{version}.js",
                "~/assets/bootstrap-{version}.js"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
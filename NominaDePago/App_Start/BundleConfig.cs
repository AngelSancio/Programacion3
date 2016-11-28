using System.Web.Optimization;

namespace IdentitySample
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/fastclick.js",
                      "~/Scripts/nprogress.js",
                      "~/Scripts/custom.js"));

            bundles.Add(new ScriptBundle("~/bundles/datatable").Include(
                     "~/Scripts/dataTables.bootstrap.js",
                     "~/Scripts/jquery.dataTables.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/font-awesome.min.css",
                      "~/Content/nprogress.css",
                      "~/Content/animate.min.css",
                      "~/Content/custom.css",
                      "~/Content/jquery.dataTables.css",
                      "~/Content/dataTables.bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}

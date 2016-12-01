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
                     "~/Scripts/jquery.dataTables.js",
                     "~/Scripts/dataTables.bootstrap.js",
                     "~/Scripts/dataTables.buttons.js",
                     "~/Scripts/buttons.bootstrap.min.js",
                     "~/Scripts/buttons.flash.js",
                     "~/Scripts/buttons.html5.min.js",
                     "~/Scripts/buttons.print.min.js",
                     "~/Scripts/dataTables.fixedHeader.js",
                     "~/Scripts/dataTables.keyTable.js",
                     "~/Scripts/dataTables.responsive.js",
                     "~/Scripts/responsive.bootstrap.js",
                     "~/Scripts/datatables.scroller.js",
                     "~/Scripts/jszip.js",
                     "~/Scripts/pdfmake.min.js",
                     "~/Scripts/vfs_fonts.js"
                     ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/font-awesome.min.css",
                      "~/Content/nprogress.css",
                      "~/Content/animate.min.css",
                      "~/Content/dataTables.bootstrap.css",
                      "~/Content/buttons.bootstrap.min.css",
                      "~/Content/fixedHeader.bootstrap.css",
                      "~/Content/responsive.bootstrap.css",
                      "~/Content/scroller.bootstrap.min.css",
                       "~/Content/MyStyle.css",
                      "~/Content/custom.css"));
        }
    }
}

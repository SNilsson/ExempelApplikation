using System.Web;
using System.Web.Optimization;

namespace Umea.se.ExempelApplikation.GUI
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/core").Include(
            "~/Scripts/site.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/datatables").Include(
             "~/Scripts/DataTables-1.10.3/jquery.dataTables.js",
             "~/Scripts/DataTables-1.10.3/jquery.dataTables.extended.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap-select").Include(
            "~/Scripts/bootstrap-select-1.6.3/bootstrap-select.js"));

            bundles.Add(new ScriptBundle("~/bundles/datepicker").Include(
            "~/Scripts/bootstrap-datepicker-1.3.0/bootstrap-datepicker.js"));

            bundles.Add(new ScriptBundle("~/bundles/toastr").Include(
            "~/Scripts/toastr-2.1.0/toastr.js",
            "~/Scripts/toastr-2.1.0/toastr.extended.js"));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/content/datatables").Include(
                    "~/Content/DataTables-1.10.3/css/jquery.dataTables.min.css"));

            bundles.Add(new StyleBundle("~/content/bootstrap-select-css").Include(
            "~/Content/bootstrap-select-1.6.3/bootstrap-select.css"));

            bundles.Add(new StyleBundle("~/content/bootstrap-datepicker").Include(
            "~/Content/bootstrap-datepicker-1.3.0/bootstrap-datepicker.css"));

            bundles.Add(new StyleBundle("~/content/toastr-css").Include(
            "~/Content/toastr-2.1.0/toastr.css"));



            // -------- View-specific Scripts ---------

            bundles.Add(new ScriptBundle("~/bundles/personIndex").Include(
                        "~/Scripts/Views/exempelapp.person.index.js"));
            bundles.Add(new ScriptBundle("~/bundles/personDetails").Include(
                        "~/Scripts/Views/exempelapp.person.details.js"));
            bundles.Add(new ScriptBundle("~/bundles/hemortIndex").Include(
                        "~/Scripts/Views/exempelapp.hemort.index.js"));

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = false;
        }
    }
}

using System.Web.Optimization;

namespace WebApplication4
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery-ui").Include(
                         "~/Content/adminlte/plugins/jquery-ui/jquery-ui.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.bundle.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                       "~/Content/bootstrap.css",
                       "~/Content/adminlte/plugins/fontawesome-free/css/all.min.css",
                       "~/Content/adminlte/plugins/daterangepicker/daterangepicker.css",
                       "~/Content/adminlte/plugins/icheck-bootstrap/icheck-bootstrap.min.css",
                       "~/Content/adminlte/plugins/jqvmap/jqvmap.min.css",
                       "~/Content/adminlte/css/adminlte.min.css",
                       "~/Content/adminlte/plugins/overlayScrollbars/css/OverlayScrollbars.min.css",
                       "~/Content/adminlte/plugins/daterangepicker/daterangepicker.css",
                       "~/Content/adminlte/plugins/summernote/summernote-bs4.min.css",
                       "~/Content/adminlte/plugins/fullcalendar/main.min.css",
                       "~/Content/adminlte/plugins/fullcalendar-daygrid/main.min.css",
                       "~/Content/adminlte/plugins/fullcalendar-bootstrap/main.min.css",
                       "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/adminlte/js").Include(
                       "~/Content/adminlte/plugins/summernote/summernote-bs4.min.js",
                       "~/Content/adminlte/plugins/fullcalendar/main.js",
                       "~/Content/adminlte/plugins/fullcalendar-daygrid/main.js",
                       "~/Content/adminlte/plugins/fullcalendar-bootstrap/main.js",
                       "~/Content/adminlte/plugins/chart.js/Chart.min.js",
                       "~/Content/adminlte/plugins/sparklines/sparkline.js",
                       "~/Content/adminlte/plugins/jqvmap/jquery.vmap.min.js",
                       "~/Content/adminlte/plugins/jqvmap/maps/jquery.vmap.usa.js",
                       "~/Content/adminlte/plugins/jquery-knob/jquery.knob.min.js",
                       "~/Content/adminlte/plugins/moment/moment.min.js",
                       "~/Content/adminlte/plugins/daterangepicker/daterangepicker.js",
                       "~/Content/adminlte/plugins/tempusdominus-bootstrap-4/js/tempusdominus-bootstrap-4.min.js",
                       "~/Content/adminlte/plugins/overlayScrollbars/js/jquery.overlayScrollbars.min.js",
                       "~/Content/adminlte/js/adminlte.min.js"));
        }
    }
}

using System.Web;
using System.Web.Optimization;

namespace StudentsHomeBudget
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/knockout").Include(
                        "~/Scripts/knockout-2.1.0.debug.js"));

            

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
               "~/Scripts/bootstrap-js/bootstrap-transition.js",
                "~/Scripts/bootstrap-js/bootstrap-alert.js",
                "~/Scripts/bootstrap-js/bootstrap-modal.js",
                "~/Scripts/bootstrap-js/bootstrap-dropdown.js",
                "~/Scripts/bootstrap-js/bootstrap-scrollspy.js",
                "~/Scripts/bootstrap-js/bootstrap-tab.js",
                "~/Scripts/bootstrap-js/bootstrap-tooltip.js",
                "~/Scripts/bootstrap-js/bootstrap-popover.js",
                "~/Scripts/bootstrap-js/bootstrap-button.js",
                "~/Scripts/bootstrap-js/bootstrap-collapse.js",
                "~/Scripts/bootstrap-js/bootstrap-carousel.js",
                "~/Scripts/bootstrap-js/bootstrap-typeahead.js"));


            //bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));
            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                        "~/Content/themes/bootstrap/css/bootstrap.css", "~/Content/themes/bootstrap/css/bootstrap-responsive.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));
        }
    }
}
using System.Web.Optimization;

namespace NetMagBundling
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Minify the CSS
            bundles.Add(new StyleBundle("~/css/minify").Include(
                "~/Content/css/bootstrap.css",
                "~/Content/css/bootstrap-responsive.css"));
        
            // Minify the JavaScript
            bundles.Add(new ScriptBundle("~/js/minify").Include(
                "~/Scripts/bootstrap.js"));
        }
    }
}

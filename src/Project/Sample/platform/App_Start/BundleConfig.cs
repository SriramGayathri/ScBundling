namespace Project.Sample.Pipelines
{
    using Sitecore.Mvc.Pipelines.Loader;
    using Sitecore.Pipelines;
    using System.Web.Optimization;
    public class BundleConfig : InitializeRoutes
    {
        public override void Process(PipelineArgs args)
        {
            RegisterBundles(BundleTable.Bundles);
        }

        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new Bundle("~/assets/css/form").Include(
              "~/assets/css/Static.min.css"));

            bundles.Add(new Bundle("~/assets/js/form").Include(
               "~/assets/js/Static.min.js"));

            BundleTable.EnableOptimizations = true;

        }
    }
}
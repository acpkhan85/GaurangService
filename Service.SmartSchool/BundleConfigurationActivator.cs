using System.Web.Optimization;

[assembly: WebActivator.PostApplicationStartMethod(typeof(Service.SmartSchool.BundleConfigurationActivator), "Activate")]
namespace Service.SmartSchool
{
    public static class BundleConfigurationActivator
    {
        public static void Activate()
        {
            BundleTable.Bundles.RegisterConfigurationBundles();
        }
    }
}
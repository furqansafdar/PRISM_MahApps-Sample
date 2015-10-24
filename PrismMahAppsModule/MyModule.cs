using Prism.Mef.Modularity;
using Prism.Modularity;
using Prism.Regions;
using System.ComponentModel.Composition;

namespace PrismMahAppsModule
{
    [ModuleExport(typeof(MyModule))]
    public class MyModule : IModule
    {
        IRegionManager _regionManager;

        [ImportingConstructor]
        public MyModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("MainRegion", typeof(ShellView));
        }
    }
}

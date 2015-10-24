using MahApps.Metro.Controls;
using Microsoft.Practices.ServiceLocation;
using Prism.Regions;
using System.ComponentModel.Composition;

namespace FSX.Prism.Bootstrapper
{
    /// <summary>
    /// Interaction logic for ShellMetro.xaml
    /// </summary>
    [Export]
    public partial class ShellMetro : MetroWindow
    {
        public ShellMetro()
        {
            InitializeComponent();

            //var regionManager = ServiceLocator.Current.GetInstance<IRegionManager>();
            //RegionManager.SetRegionManager(Flyouts, regionManager);
        }
    }
}

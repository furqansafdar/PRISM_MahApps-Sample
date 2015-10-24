using MahApps.Metro.Controls;
using Prism.Mef;
using Prism.Regions;
using System;
using System.ComponentModel.Composition.Hosting;
using System.Windows;

namespace FSX.Prism.Bootstrapper
{
    [CLSCompliant(false)]
    public partial class Bootstrapper : MefBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return this.Container.GetExportedValue<ShellMetro>();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();
            Application.Current.MainWindow = (ShellMetro)this.Shell;
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureAggregateCatalog()
        {
            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(System.Reflection.Assembly.GetExecutingAssembly()));
            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(PrismMahAppsModule.MyModule).Assembly));
        }

        protected override RegionAdapterMappings ConfigureRegionAdapterMappings()
        {
            var mappings = base.ConfigureRegionAdapterMappings();
            // Register custom region adapters
            mappings.RegisterMapping(typeof(FlyoutsControl), Container.GetExportedValue<FlyoutsControlRegionAdapter>());
            return mappings;
        }
    }
}
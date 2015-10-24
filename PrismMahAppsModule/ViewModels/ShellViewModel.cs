using Microsoft.Practices.ServiceLocation;
using Prism.Commands;
using Prism.Regions;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Windows.Input;

namespace PrismMahAppsModule
{
    [Export]
    public class ShellViewModel
    {
        [ImportingConstructor]
        public ShellViewModel()
        {
            ToggleFlyoutCommand = new DelegateCommand<object>(ToggleFlyout);
            IRegionManager regionManager = ServiceLocator.Current.GetInstance<IRegionManager>();
            if (regionManager == null) throw new ArgumentNullException("regionManager");
            regionManager.RegisterViewWithRegion("FlyoutRegion", typeof(FlyoutBottomView));
            regionManager.RegisterViewWithRegion("FlyoutRegion", typeof(FlyoutTopView));
        }

        public ICommand ToggleFlyoutCommand { get; private set; }

        public void ToggleFlyout(object param)
        {
            var side = (string)param;
            if (side == "Top")
            {
                var vm = ServiceLocator.Current.GetInstance<FlyoutTopViewModel>();
                vm.IsOpen = !vm.IsOpen;
            }
            else
            {
                var vm = ServiceLocator.Current.GetInstance<FlyoutBottomViewModel>();
                vm.IsOpen = !vm.IsOpen;
            }
        }
    }
}
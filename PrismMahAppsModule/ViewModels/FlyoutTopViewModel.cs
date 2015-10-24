using MahApps.Metro.Controls;
using System.ComponentModel.Composition;

namespace PrismMahAppsModule
{
    [Export]
    [PartCreationPolicy(CreationPolicy.Shared)]
    public class FlyoutTopViewModel : FlyoutBaseViewModel
    {
        public FlyoutTopViewModel()
        {
            this.Header = "Top";
            this.Position = Position.Top;
        }
    }
}
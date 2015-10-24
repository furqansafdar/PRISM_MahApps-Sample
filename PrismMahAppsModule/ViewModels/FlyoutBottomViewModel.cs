using MahApps.Metro.Controls;
using System.ComponentModel.Composition;

namespace PrismMahAppsModule
{
    [Export]
    [PartCreationPolicy(CreationPolicy.Shared)]
    public class FlyoutBottomViewModel : FlyoutBaseViewModel
    {
        public FlyoutBottomViewModel()
        {
            this.Header = "Bottom";
            this.Position = Position.Bottom;
        }
    }
}
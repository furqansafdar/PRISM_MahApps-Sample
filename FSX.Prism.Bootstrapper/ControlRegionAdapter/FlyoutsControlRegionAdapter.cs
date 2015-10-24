using System.Windows;
using System.Collections.Specialized;
using System.ComponentModel.Composition;
using Prism.Regions;
using MahApps.Metro.Controls;

namespace FSX.Prism.Bootstrapper
{
[Export]
public class FlyoutsControlRegionAdapter : RegionAdapterBase<FlyoutsControl>
{
    [ImportingConstructor]
    public FlyoutsControlRegionAdapter(IRegionBehaviorFactory factory)
        : base(factory)
    {
    }

    protected override void Adapt(IRegion region, FlyoutsControl regionTarget)
    {
        region.ActiveViews.CollectionChanged += (s, e) =>
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (FrameworkElement element in e.NewItems)
                {
                    Flyout flyout = new Flyout();
                    flyout.Content = element;
                    flyout.DataContext = element.DataContext;
                    regionTarget.Items.Add(flyout);
                }
            }
        };
    }

    protected override IRegion CreateRegion()
    {
        return new AllActiveRegion();
    }
}
}

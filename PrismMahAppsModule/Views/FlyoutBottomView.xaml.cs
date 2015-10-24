using System.ComponentModel.Composition;
using System.Windows.Controls;

namespace PrismMahAppsModule
{
    /// <summary>
    /// Interaction logic for FlyoutBottomView.xaml
    /// </summary>
    [Export]
    public partial class FlyoutBottomView : UserControl
    {
        public FlyoutBottomView()
        {
            InitializeComponent();
        }

        //[Import]
        //private FlyoutBottomViewModel ViewModel
        //{
        //    get { return (FlyoutBottomViewModel)this.DataContext; }
        //    set { this.DataContext = value; }
        //}
    }
}

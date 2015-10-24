using System.ComponentModel.Composition;
using System.Windows.Controls;

namespace PrismMahAppsModule
{
    /// <summary>
    /// Interaction logic for ShellView.xaml
    /// </summary>
    [Export]
    public partial class ShellView : UserControl
    {
        public ShellView()
        {
            InitializeComponent();
        }

        [Import]
        private ShellViewModel ViewModel
        {
            get { return (ShellViewModel)this.DataContext; }
            set { this.DataContext = value; }
        }
    }
}

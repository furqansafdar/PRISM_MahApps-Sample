using MahApps.Metro.Controls;
using Prism.Mvvm;
using System.ComponentModel.Composition;

namespace PrismMahAppsModule
{
    [Export]
    [PartCreationPolicy(CreationPolicy.Shared)]
    public abstract class FlyoutBaseViewModel : BindableBase
    {
        private string header;        
        public string Header
        {
            get { return this.header; }
            set { SetProperty(ref this.header, value); }
        }

        private bool isOpen;
        public bool IsOpen
        {
            get { return this.isOpen; }
            set { SetProperty(ref this.isOpen, value); }
        }
        
        private Position position;
        public Position Position
        {
            get { return this.position; }
            set { SetProperty(ref this.position, value); }
        }
    }
}
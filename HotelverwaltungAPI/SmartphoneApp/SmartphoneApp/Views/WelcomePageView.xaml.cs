using SmartphoneApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartphoneApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePageView : ContentPage
    {
        private WelcomePageViewModel _vm = new WelcomePageViewModel();
        public WelcomePageView()
        {
            InitializeComponent();

            this.BindingContext = _vm;
        }
    }
}
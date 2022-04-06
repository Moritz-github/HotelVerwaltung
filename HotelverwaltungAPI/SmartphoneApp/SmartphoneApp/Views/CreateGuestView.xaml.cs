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
    public partial class CreateUserView : ContentPage
    {
        CreateGuestViewModel _vm = new CreateGuestViewModel();
        public CreateUserView()
        {
            InitializeComponent();
            this.BindingContext = _vm;

        }
    }
}
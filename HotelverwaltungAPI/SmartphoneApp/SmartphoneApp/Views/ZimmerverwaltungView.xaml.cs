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
    public partial class ZimmerverwaltungView : ContentPage
    {
        ZimmerverwaltungViewModel _vm = new ZimmerverwaltungViewModel();

        public ZimmerverwaltungView()
        {
            InitializeComponent();

            this.BindingContext = _vm;
        }
    }
}
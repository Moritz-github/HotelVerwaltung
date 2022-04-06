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
    public partial class AlleGaesteAnzeigen: ContentPage
    {
        AlleGaesteAnzeigenViewModel _vm = new AlleGaesteAnzeigenViewModel();

        public AlleGaesteAnzeigen()
        {
            InitializeComponent();

            this.BindingContext = _vm;
        }
    }
}
using SmartphoneApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SmartphoneApp.ViewModels
{
    class WelcomePageViewModel : Models.common.BindingBase
    {
        public ICommand CmdShowZimmerverwaltung => new Command(ShowZimmerverwaltung);

        private async void ShowZimmerverwaltung()
        {
            ZimmerverwaltungView view = new ZimmerverwaltungView();

            await Application.Current.MainPage.Navigation.PushModalAsync(view);
        }

        public ICommand CmdShowUserverwaltung => new Command(ShowUserverwaltung);

        private async void ShowUserverwaltung()
        {
            UserverwaltungView view = new UserverwaltungView();

            await Application.Current.MainPage.Navigation.PushModalAsync(view);
        }
    }
}

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

        public ICommand CmdShowGuests => new Command(ShowGuests);

        public ICommand CmdCreateUser => new Command(async () =>
        {
            CreateUserView view = new CreateUserView();

            await Application.Current.MainPage.Navigation.PushModalAsync(view);
        });

        private async void ShowGuests()
        {
            AlleGaesteAnzeigen view = new AlleGaesteAnzeigen();

            await Application.Current.MainPage.Navigation.PushModalAsync(view);
        }
    }
}

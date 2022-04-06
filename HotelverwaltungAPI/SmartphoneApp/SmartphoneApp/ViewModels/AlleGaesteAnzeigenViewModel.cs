using SmartphoneApp.Models;
using SmartphoneApp.Models.services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SmartphoneApp.ViewModels
{
    class AlleGaesteAnzeigenViewModel : Models.common.BindingBase
    {
        // Data binding 
        private ObservableCollection<Guest> _guests = new ObservableCollection<Guest>();

        public ObservableCollection<Guest> Guests
        {
            get { return this._guests; }
            set
            {
                this._guests = value;
                this.RaisePropertyChanged(nameof(Guests));
            }
        }

        public ICommand CmdLaden => new Command(Laden);

        async void Laden()
        {
            this.Guests = await APIController.getInstance().getAllGuests();
        }

        public ICommand CmdBack => new Command(async () =>
        {
            await App.Current.MainPage.Navigation.PopModalAsync();
        });

        public AlleGaesteAnzeigenViewModel()
        {
            this.Laden();
        }

    }
}

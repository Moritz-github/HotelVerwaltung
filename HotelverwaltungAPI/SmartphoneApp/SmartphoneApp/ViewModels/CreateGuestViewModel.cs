using SmartphoneApp.Models.common;
using SmartphoneApp.Models.services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SmartphoneApp.ViewModels
{
    class CreateGuestViewModel : Models.common.BindingBase
    {
        private int _id;
        private String _firstname;
        private String _lastname;
        private DateTime _birthdate;
        private String _language;
        private String _email;

        public int Id
        {
            get { return this._id; }
            set
            {
                this._id = value;
                this.RaisePropertyChanged(nameof(Id));
            }
        }

        public string Firstname
        {
            get { return this._firstname; }
            set
            {
                this._firstname = value;
                this.RaisePropertyChanged(nameof(Firstname));
            }
        }


        public string Lastname
        {
            get { return this._lastname; }
            set
            {
                this._lastname = value;
                this.RaisePropertyChanged(nameof(Lastname));
            }
        }

        public DateTime Birthdate
        {
            get { return this._birthdate; }
            set
            {
                this._birthdate = value;
                this.RaisePropertyChanged(nameof(Birthdate));
            }
        }

        public string Language
        {
            get { return this._language; }
            set
            {
                this._language = value;
                this.RaisePropertyChanged(nameof(Language));
            }
        }

        public string Email
        {
            get { return this._email; }
            set
            {
                this._email = value;
                this.RaisePropertyChanged(nameof(Email));
            }
        }
        public ICommand CmdBack => new Command(async () =>
        {
            await App.Current.MainPage.Navigation.PopModalAsync();
        });

        public ICommand CmdCreate => new Command(addGuest);

        public async void addGuest()
        {
            Debug.WriteLine("ADDING GUEST");
            bool succ = await APIController.getInstance().addGuest(
               new Models.Guest(Id, Firstname, Lastname, Birthdate, Language, Email) );
            if (succ)
            {
                await App.Current.MainPage.Navigation.PopModalAsync();
            }
        }
    }
}

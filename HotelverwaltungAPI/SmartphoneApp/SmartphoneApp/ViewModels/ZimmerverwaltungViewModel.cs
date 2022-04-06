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
    class ZimmerverwaltungViewModel : Models.common.BindingBase
    {
        // Data binding 
        private ObservableCollection<Room> _rooms = new ObservableCollection<Room>();

        public ObservableCollection<Room> Rooms
        {
            get { return this._rooms; }
            set
            {
                this._rooms = value;
                this.RaisePropertyChanged(nameof(Rooms));
            }
        }

        private DateTime startDate;
        private DateTime endDate;

        public DateTime StartDate
        {
            get { return this.startDate; }
            set
            {
                this.startDate = value;
                this.RaisePropertyChanged(nameof(StartDate));
            }
        }
        public DateTime EndDate
        {
            get { return this.endDate; }
            set
            {
                this.endDate = value;
                this.RaisePropertyChanged(nameof(EndDate));
            }
        }

        public ICommand CmdLaden => new Command(Laden);

        async void Laden()
        {
            this.Rooms = await APIController.getInstance().getFreeRoomsByDate(StartDate, EndDate);
        }

        public ICommand CmdBack => new Command(async () =>
        {
            await App.Current.MainPage.Navigation.PopModalAsync();
        });

        public ZimmerverwaltungViewModel()
        {
            StartDate = DateTime.Now;
            EndDate = DateTime.Now;
        }
    }
}

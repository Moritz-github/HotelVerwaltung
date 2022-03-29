using SmartphoneApp.Models;
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

        // Commands
        public ICommand CmdClose => new Command(Close);

        private void Close()
        {
            Application.Current.MainPage.Navigation.PopModalAsync();
        }


        public ZimmerverwaltungViewModel()
        {
            Rooms.Add(new Room(5, 5, false, false, true, 25.0M));
        }
    }
}

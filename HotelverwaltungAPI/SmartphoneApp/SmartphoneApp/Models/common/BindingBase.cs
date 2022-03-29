using System;
using System.ComponentModel;

namespace SmartphoneApp.Models.common {

    public class BindingBase : INotifyPropertyChanged {

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(params string[] propertyNames) {
            foreach (string propertyName in propertyNames) {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

}

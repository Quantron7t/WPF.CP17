using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Cars.DAL.Model;

namespace WPF.MVVM.Cars.ViewModel
{
    class CarDetailViewModel: INotifyPropertyChanged
    {
        private Car _SelectedCar;

        public event PropertyChangedEventHandler PropertyChanged;

        public Car SelectedCar
        {
            get { return _SelectedCar; }
            set
            {
                _SelectedCar = value;
                RaisePropertyChanged("SelectedCar");
            }
        }

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged!=null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

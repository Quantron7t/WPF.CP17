using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Cars.DAL.Model;
using WPF.MVVM.Cars.Utility;

namespace WPF.MVVM.Cars.ViewModel
{
    public class CarDetailViewModel: INotifyPropertyChanged
    {        
        public event PropertyChangedEventHandler PropertyChanged;

        public CarDetailViewModel()
        {
            Messenger.Default.Register<Car>(this, OnCarReceived);
        }

        private void OnCarReceived(Car car)
        {
            SelectedCar = car;
        }

        private Car _SelectedCar;

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

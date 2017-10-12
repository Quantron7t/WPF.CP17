using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF.Cars.DAL.Model;
using WPF.MVVM.Cars.Messages;
using WPF.MVVM.Cars.Services;
using WPF.MVVM.Cars.Utility;

namespace WPF.MVVM.Cars.ViewModel
{
    public class CarDetailViewModel: INotifyPropertyChanged
    {        
        public event PropertyChangedEventHandler PropertyChanged;
        CarDataService carDataService;
        public ICommand DeleteCommand { get; set; }  

        public CarDetailViewModel()
        {
            Messenger.Default.Register<Car>(this, OnCarReceived);
            DeleteCommand = new CustomCommand(DeleteCar,canDeleteCar);
            carDataService = new CarDataService();
        }

        private bool canDeleteCar(object obj)
        {
            if (SelectedCar!=null)
            {
                return true;
            }
            return false;
        }

        private void DeleteCar(object obj)
        {
            carDataService.DeleteCar(SelectedCar);
            Messenger.Default.Send<UpdateListMessage>(new UpdateListMessage());          
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

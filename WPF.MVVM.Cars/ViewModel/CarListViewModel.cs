using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF.Cars.DAL.Model;
using WPF.MVVM.Cars.Services;
using WPF.MVVM.Cars.Utility;

namespace WPF.MVVM.Cars.ViewModel
{
    public class CarListViewModel : INotifyPropertyChanged
    {

        //adding command to list UI Controls
        public ICommand ViewCommand{ get; set; }        

        private CarDataService carDataService;
        private DialogService dialogService; 

        public CarListViewModel()
        {
            carDataService = new CarDataService();
            dialogService = new DialogService();
            LoadData();
            //attaching command
            LoadCommand();
        }

        private void LoadCommand()
        {
            ViewCommand = new CustomCommand(ViewCar, CanViewCar);
        }

        private bool CanViewCar(object obj)
        {
            return true;
        }

        private void ViewCar(object obj)
        {
            Messenger.Default.Send<Car>(SelectedCar);
            dialogService.ShowCarDetailView();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        //Getting SelectedCar from the UI
        private Car _SelectedCar;

        public Car SelectedCar
        {
            get { return _SelectedCar; }
            set
            {
                _SelectedCar = value;
                RaisePropertyChanged("SelectedCar");
                Messenger.Default.Send<Car>(SelectedCar);
                dialogService.ShowCarDetailView();
            }
        }


        private List<Car> _Cars;

        public List<Car> Cars
        {
            get { return _Cars; }
            set
            {
                _Cars = value;
                RaisePropertyChanged("Cars");
            }
        }

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged!=null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void LoadData()
        {
            Cars = carDataService.GetCars();
        }
    }
}

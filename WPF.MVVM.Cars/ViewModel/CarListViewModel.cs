using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Cars.DAL.Model;
using WPF.MVVM.Cars.Services;

namespace WPF.MVVM.Cars.ViewModel
{
    class CarListViewModel : INotifyPropertyChanged
    {
        private CarDataService carDataService;

        public CarListViewModel()
        {
            carDataService = new CarDataService();
            LoadData();
        }

        public event PropertyChangedEventHandler PropertyChanged;

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

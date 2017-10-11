using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.MVVM.Cars.ViewModel;

namespace WPF.MVVM.Cars
{
    public class ViewModelLocator 
    {
        private static CarListViewModel carListViewModel = new CarListViewModel();
        private static CarDetailViewModel carDetailViewModel = new CarDetailViewModel();

        public static CarListViewModel CarListViewModel
        {
            get
            {
                return carListViewModel;
            }
        }

        public static CarDetailViewModel CarDetailViewModel
        {
            get
            {
                return carDetailViewModel;
            }
        }
    }
}

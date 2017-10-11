using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.MVVM.Cars.ViewModel;

namespace WPF.MVVM.Cars
{
    class ViewModelLocator 
    {
        private static CarListViewModel carListViewModel = new CarListViewModel();
        
        public static CarListViewModel CarListViewModel
        {
            get
            {
                return carListViewModel;
            }
        }
    }
}

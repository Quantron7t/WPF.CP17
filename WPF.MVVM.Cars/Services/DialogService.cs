using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPF.MVVM.Cars.View;

namespace WPF.MVVM.Cars.Services
{
    //class that helps to Navigate between WPF Windows/Views
    class DialogService
    {
        Window carDetailView = null;

        public void ShowCarDetailView()
        {
            carDetailView = new CarDetailView();
            carDetailView.ShowDialog();
        }

        public void CloseCarDetailView()
        {
            if (carDetailView!=null)
            {
                carDetailView.Close();
            } 
        }
    }
}

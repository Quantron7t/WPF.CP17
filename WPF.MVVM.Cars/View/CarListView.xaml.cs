using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPF.Cars.DAL.Model;
using WPF.MVVM.Cars.Services;

namespace WPF.MVVM.Cars.View
{
    /// <summary>
    /// Interaction logic for CarListView.xaml
    /// </summary>
    public partial class CarListView : Window
    {

        //private Car selectedCar; 

        public CarListView()
        {
            InitializeComponent();

            //LoadListView();
        }

        //private void LoadListView()
        //{
        //    CarDataService carDataService = new CarDataService();
        //    CarListControl.ItemsSource = carDataService.GetCars();
        //}

        //private void CarListControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    //selectedCar = e.AddedItems[0] as Car;

        //    //if (selectedCar != null)
        //    //{
        //    //    CarDetailView carDetailView = new CarDetailView();
        //    //    carDetailView.SelectedCar = selectedCar;
        //    //    carDetailView.ShowDialog();
        //    //}
        //}
    }
}

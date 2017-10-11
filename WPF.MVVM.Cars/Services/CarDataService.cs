using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Cars.DAL.Model;
using WPF.Cars.DAL;

namespace WPF.MVVM.Cars.Services
{
    class CarDataService : ICarDataService
    {
        ICarRepository carRepository = new CarRepository();

        public void AddCar(Car car)
        {
            carRepository.AddCar(car);
        }

        public void DeleteCar(Car car)
        {
            carRepository.DeleteCar(car);
        }

        public Car GetCar(int id)
        {
            return carRepository.GetCar(id);
        }

        public List<Car> GetCars()
        {
            return carRepository.GetCars();
        }

        public void UpdateCar(Car car)
        {
            carRepository.UpdateCar(car);
        }
    }
}

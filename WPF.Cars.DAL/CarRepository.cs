using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Cars.DAL.Model;

namespace WPF.Cars.DAL
{
    public class CarRepository : ICarRepository
    {
        private static List<Car> cars;

        public CarRepository()
        {

        }

        private void LoadCars()
        {
            cars = new List<Car>() {
                new Car(){ Id = 1,Name = "Mercedes-Benz SLR", Country=Country.Germany, Price = 500000, Type= "Grand Tourer" },
                new Car(){ Id = 2,Name = "McLaren P1", Country=Country.UK, Price = 1150000, Type= "HyperCar" },
                new Car(){ Id = 3,Name = "Koenigsegg Regera", Country=Country.Sweden, Price = 1250000, Type= "HyperCar" },
                new Car(){ Id = 4,Name = "Ferrari 458 Italia", Country=Country.Italy, Price = 400000, Type= "Gran Tourismo" }
            };
        }

        public void AddCar(Car car)
        {
            cars.Add(car);
        }

        public void DeleteCar(Car car)
        {
            cars.Remove(car);
        }

        public Car GetCar(int id)
        {
            if (cars==null)
            {
                LoadCars();
            }
            return cars.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<Car> GetCars()
        {
            if (cars == null)
            {
                LoadCars();
            }
            return cars;
        }

        public void UpdateCar(Car car)
        {
            Car updateCar = cars.Where(c => c.Id.Equals(car.Id)).FirstOrDefault();
            updateCar = car;
        }
    }
}

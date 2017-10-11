﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Cars.DAL.Model;

namespace WPF.Cars.DAL
{
    public interface ICarRepository
    {
        List<Car> GetCars();
        Car GetCar(int id);
        void DeleteCar(Car car);
        void UpdateCar(Car car);
        void AddCar(Car car);

    }
}

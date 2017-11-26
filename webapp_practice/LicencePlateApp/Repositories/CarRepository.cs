using System;
using System.Collections.Generic;
using System.Linq;
using LicencePlateApp.Entities;
using LicencePlateApp.Models;

namespace LicencePlateApp.Repositories
{
    public class CarRepository
    {
        CarContext CarContext;

        public CarRepository(CarContext carContext)
        {
            CarContext = carContext;
        }

        public List<Car> GetAllCars()
        {
            return CarContext.Licence_Plates.ToList();
        }
    }
}

using System;
using LicencePlateApp.Entities;

namespace LicencePlateApp.Repositories
{
    public class CarRepository
    {
        CarContext CarContext;

        public CarRepository(CarContext carContext)
        {
            CarContext = carContext;
        }

    }
}

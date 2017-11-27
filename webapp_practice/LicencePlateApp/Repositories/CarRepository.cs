using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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

        public bool CheckInputFormat(string plate)
        {
            return Regex.IsMatch(plate, @"^[a-zA-Z0-9-]*$");
        }

        public bool CheckInputLength(string plate)
        {
            return (plate.Length <= 7);
        }

        public List<Car> GetResultFromDb(string plate)
        {
            if (CheckInputFormat(plate) && CheckInputFormat(plate))
            {
                return CarContext.Licence_Plates.Where(x => x.Plate.Contains(plate)).ToList();
            }
            return GetAllCars();
        }

        public List<Car> PoliceCars()
        {
            return CarContext.Licence_Plates.Where(x => x.Plate.StartsWith("RB")).ToList();
        }

        public List<Car> DiplomatCars()
        {
            return CarContext.Licence_Plates.Where(x => x.Plate.StartsWith("DT")).ToList();
        }
    }
}

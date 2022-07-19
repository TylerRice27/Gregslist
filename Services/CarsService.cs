using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gregslist.db;
using Gregslist.Models;

namespace Gregslist.Services
{
    public class CarsService
    {

        internal List<Car> Get()
        {
            return FakeDb.Cars;
        }

        internal Car Get(string id)

        {
            Car found = FakeDb.Cars.Find(c => c.Id == id);
            if (found == null)
            {
                throw new Exception("Invaild Id");
            }
            return found;
        }


        internal Car Create(Car carData)
        {
            FakeDb.Cars.Add(carData);
            return carData;
        }

        internal Car Update(Car carData)
        {

            Car original = Get(carData.Id);

            original.Make = carData.Make ?? original.Make;
            original.Model = carData.Model ?? original.Model;
            original.Price = carData.Price ?? original.Price;

            return original;
        }
        internal Car Delete(string id)
        {
            Car found = Get(id);
            FakeDb.Cars.Remove(found);
            return found;
        }
    }
}
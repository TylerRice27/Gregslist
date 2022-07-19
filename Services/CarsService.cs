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

        internal Car Delete(string id)
        {
            throw new NotImplementedException();
        }

        internal Car Create(Car carData)
        {
            throw new NotImplementedException();
        }

        internal Car Update(Car carData)
        {
            throw new NotImplementedException();
        }
    }
}
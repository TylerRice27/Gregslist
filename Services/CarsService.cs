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


    }
}
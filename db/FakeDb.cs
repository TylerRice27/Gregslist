using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gregslist.Models;

namespace Gregslist.db
{
    public static class FakeDb
    {

        public static List<Car> Cars { get; set; } = new List<Car>()
        {
        new Car("Honda", "Civic", 1000),
        new Car("BMW", "M5", 200),
        new Car("Ferrari", "Aventdor", 300)
        };

    }
}
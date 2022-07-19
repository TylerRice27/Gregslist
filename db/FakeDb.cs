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
        new Car("Honda"),
        new Car("BMW"),
        new Car("Ferrari")
        };

    }
}
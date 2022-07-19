using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gregslist.Models
{

    public class House
    {

        public House(string address, int? floors, int? price)
        {

        }

        public string Id { get; set; }

        public string address { get; set; }

        public int? floors { get; set; }

        public int? price { get; set; }

    }
}
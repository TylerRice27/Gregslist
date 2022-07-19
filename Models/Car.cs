

using System;

namespace Gregslist.Models
{
    public class Car
    {
        public Car(string make, string model, int? price)
        {
            Id = Guid.NewGuid().ToString();
            Make = make;
            Model = model;
            Price = price;
        }



        public string Id { get; set; }
        public string Make { get; set; }

        public string Model { get; set; }

        public int? Price { get; set; }
    }

}
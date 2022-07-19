

using System;

namespace Gregslist.Models
{
    public class Car
    {
        public Car(string make, string model)
        {
            Id = Guid.NewGuid().ToString();
            Make = make;
            Model = Model;
        }



        public string Id { get; set; }
        public string Make { get; set; }

        public string Model { get; set; }
    }

}
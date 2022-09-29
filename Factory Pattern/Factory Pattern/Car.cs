using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class Car : IVehicle
    {
        public int NumWheels { get; set; } = 4;
        public string Type { get; set; } = "Car";

        public void Drive()
        {
            Console.WriteLine($"Building a new {Type}!");
        }

    }
}

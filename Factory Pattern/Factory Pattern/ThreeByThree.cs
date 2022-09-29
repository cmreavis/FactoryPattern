using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class ThreeByThree : IVehicle
    {
        public int NumWheels { get; set; } = 6;
        public string Type { get; set; } = "3 x 3";

        public void Drive()
        {
            Console.WriteLine($"Building a new {Type}!");
        }

    }
}

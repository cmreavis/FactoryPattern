using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class Motorcycle : IVehicle
    {
        public int NumWheels { get; set; } = 2;
        public string Type { get; set; } = "Motorcycle";

        public void Drive()
        {
            Console.WriteLine($"Building a new {Type}!");
        }
    }

    

}

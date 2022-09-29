using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int numWheels)
        {
            if (numWheels == 2)
            {
                return new Motorcycle();
            }
            else if (numWheels == 4)
            {
                return new Car();
            }
            else if (numWheels == 6)
            {
                return new ThreeByThree();
            }
            else return new Car();
        }



    }
}

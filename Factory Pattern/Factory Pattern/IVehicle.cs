using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public interface IVehicle
    {
        abstract int NumWheels { get; set; }
        //stubbed out Drive method
        public void Drive()
        {
           
        }

    }
}

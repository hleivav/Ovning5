using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garaget
{
    internal class Car : Vehicle
    {
        public bool FuelCar { get; set; }
        public Car(string type, string make, string color, string capacity, bool fuelCar) : base(type, make, color, capacity)
        {
            FuelCar = fuelCar;  
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garaget
{
    internal class Motorcycle : Vehicle
    {
        public double CylinderVolume { get; set; }
        public Motorcycle(string type, string make, string color, string capacity, double cilinderVolum) : base (type, make, color, capacity)
        {
            Type = type;
            Make = make;
            Color = color;
            Capacity = capacity;

        }
    }
}

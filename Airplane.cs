using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garaget
{

    internal class Airplane : Vehicle
    {
        public int NoOfEngines { get; set; }
        public Airplane(string type, string make, string color, string capacity, int noOfEngines) : base (type, make, color, capacity)
        {
            Type = type;
            Make = make;
            Color = color;
            Capacity = capacity;
            NoOfEngines = noOfEngines;  
        }
    }
}

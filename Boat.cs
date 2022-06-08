using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garaget
{
    internal class Boat : Vehicle
    {
        public int MaximunSpeed { get; set; }
        public Boat(string type, string make, string color, string capacity, int maximumSpeed) : base(type, make, color, capacity)
        {
            MaximunSpeed = maximumSpeed;    
        }
    }
}

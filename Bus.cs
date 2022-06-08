using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garaget
{
    internal class Bus : Vehicle
    {
        public int NoOfSeats { get; set; }
        public Bus(string type, string make, string color, string capacity, int noOfSeats) : base(type, make, color, capacity)
        {
            NoOfSeats = noOfSeats;  
        }
    }
}

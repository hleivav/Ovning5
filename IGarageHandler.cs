using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace garaget
{
    internal interface IGarageHandler
    {

        public void ParkVehicle(Vehicle vehicle) {  }    
        public void RemoveVehicle(Vehicle vehicle, int regNo) { }
        public void SearchVehicleByReg(Vehicle vehicle, int regNo) { }
        public void ListAllVehicles() { }
        
    }
}

using System.Collections;
using System.Collections.Generic;

namespace garaget
{
    internal class Garage<T>
    {
        public int NoOfVehicles { get; }
        public readonly T[] VehicleArray ; 



        public Garage(int noOfVehicles)
        {
            NoOfVehicles = noOfVehicles; 
            VehicleArray = new T[NoOfVehicles];

        } 


    }
}
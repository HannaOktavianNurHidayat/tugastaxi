using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxi_class
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // membuat objek dari class Taxi
            taxi taxi = new taxi();

            // pengesetan nilai properties
            taxi.DriverName = "Jono";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            // pemanggilan method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxi_class
{
    class taxi
    {
        //properties
        public string Taxi { get; set; }
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        // method 
        public void TaxiInfo()
        {

            Console.WriteLine("DriverName: Jono");
            if (OnDuty) Console.WriteLine("On Duty: Yes");
            else Console.WriteLine("On Duty : No ");
            Console.WriteLine("Number Of Passengers : 10");
            Console.WriteLine();
        }
            public void PickUpPassenger()
            {
                Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
                Console.WriteLine();
            }
            public void DropOffPassenger()
            {
                Console.WriteLine("{0} selesai mengatar penumpang", DriverName);
                Console.WriteLine();
            }

        }

    }



   

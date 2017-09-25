using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vehicles
{
    class Airplane : Vehicle
    {
        public void TakeOff()
        {
            Console.WriteLine("Taking off"); // Decolando
        }

        public void Land()
        {
            Console.WriteLine("Landing"); // Aterissando
        }

        public override void Drive()
        {
            Console.WriteLine("Flying");
        }
    }
}
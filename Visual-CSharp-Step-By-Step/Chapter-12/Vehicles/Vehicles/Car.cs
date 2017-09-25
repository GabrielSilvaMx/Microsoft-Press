using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vehicles
{
    class Car : Vehicle
    {
        public void Accelerate()
        {
            Console.WriteLine("Accelerating"); // Acelerando
        }

        public void Brake()
        {
            Console.WriteLine("Breaking"); // Acionando o freio
        }

        public override void Drive()
        {
            Console.WriteLine("Motoring");
        }
    }
}

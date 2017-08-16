#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace StructsAndEnums
{
    class Program
    {
        static void DoWork()
        {
            Month first = Month.January;
            Console.WriteLine(first);
            first++;
            Console.WriteLine(first);
            first = Month.December;
            Console.WriteLine(first);
            first++; // Incrementa ao terminar a enumeração
            Console.WriteLine(first); // Escreve 12
        }

        static void Main()
        {
            try
            {
                DoWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

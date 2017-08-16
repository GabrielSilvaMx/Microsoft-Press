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
            // Escreve January
            Month first = Month.January;
            Console.WriteLine(first);

            // Incrementa e escreve February
            first++;
            Console.WriteLine(first);

            // Escreve o último item da enum
            first = Month.December;
            Console.WriteLine(first);
            first++; // Incrementa ao terminar a enumeração
            Console.WriteLine(first); // Escreve 12
            Console.WriteLine();

            // Escreve uma data default
            Date defaultDate = new Date();
            Console.WriteLine(defaultDate);

            // Escreve uma data
            Date weddingAnniversary = new Date(2010, Month.July, 4);
            Console.WriteLine(weddingAnniversary);

            // Cópia da estrutura
            Date weddingAnniversaryCopy = weddingAnniversary;
            Console.WriteLine("O valor da cópia é {0}", weddingAnniversaryCopy);

            // Avançando um mês
            weddingAnniversaryCopy.AdvanceMonth();
            Console.WriteLine("O novo valor de weedingAnniversary é {0}", weddingAnniversary);
            Console.WriteLine("O valor da cópia é {0}", weddingAnniversaryCopy);

            // Se fosse uma classe em vez de estrutura
            Console.WriteLine("\nCompare com classes:\n");
            DateClass weddingAnniversaryClass = new DateClass(2010, Month.July, 4);
            DateClass weddingAnniversaryClassCopy = weddingAnniversaryClass;
            weddingAnniversaryClassCopy.AdvanceMonth();
            Console.WriteLine("O novo valor de weedingAnniversary é {0}", weddingAnniversaryClass);
            Console.WriteLine("O valor da cópia é {0}", weddingAnniversaryClassCopy);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practicaCsharp.exercises
{
    public class CicloFor
    {
        public static void cicloFor()
        {
             int i;
            System.Console.WriteLine("numeros ascendentesde l 0 al 100");
            for (i = 0; i <= 100; i++)
            {
                System.Console.WriteLine(i);
            }
            System.Console.WriteLine("numeros ascendentesde l 0 al 100");
            for (i = 100; i >=0 ; i--)
            {
                System.Console.WriteLine(i);
            }
        }
    }
}
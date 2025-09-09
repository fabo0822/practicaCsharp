using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practicaCsharp.exercises
{
    public class IngresoDeDatos
    {
        public static void dataEntry()
        {
            int num = 0;
            int suma = 0;

            do
            {
                Console.WriteLine("ingresa un numero: ");
                num = int.Parse(Console.ReadLine());
                suma = suma + num;

            } while (num != 0);
            Console.WriteLine($"la suma es {suma}");
            
        }
    }
}
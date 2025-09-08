using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practicaCsharp.exercises
{
    public class MayorMenorIgual
    {
        public static void GreaterLessEqual()
        {
             int num1, num2;
            System.Console.WriteLine("ingrese el numero 1");
            num1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("ingrese el numero 2");
            num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                System.Console.WriteLine($"el numero {num1} es mayor que {num2}");
            }
            else if (num1 < num2)
            {
                System.Console.WriteLine($"el numero {num1} es menor que {num2}");
            }
            else
            {
                System.Console.WriteLine($"los numeros son iguales");
            }
        } 
    }
}
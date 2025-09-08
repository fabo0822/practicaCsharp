using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practicaCsharp.exercises
{
    public class Operation
    {
        public static void calcular()
        {
            int num1, num2, result;
            Console.WriteLine("ingrese el numero 1");
            num1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("ingrese el numero 2");
            num2 = int.Parse(Console.ReadLine());
            result = num1 + num2;
            System.Console.WriteLine($"la suma es: {result}");
            if (num2 != 0)
            {
                result = num1 / num2;
                System.Console.WriteLine($"la division es {result}");
            }
        }
    }
}
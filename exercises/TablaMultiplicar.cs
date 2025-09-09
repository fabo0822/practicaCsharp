using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practicaCsharp.exercises
{
    public interface TablaMultiplicar
    {
        public static void multiplyTable()
        {
             int num = 0, i = 1, resultado = 0;
            System.Console.WriteLine("cual tabla de multiplicar quieres");
            num = int.Parse(Console.ReadLine());
            while (i <= 10)
            {
                resultado = num * i;
                System.Console.WriteLine($"{num} * {i} = {resultado}");
                i++;
            }
        }
    }
}
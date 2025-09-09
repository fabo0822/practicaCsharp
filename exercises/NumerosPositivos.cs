using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace practicaCsharp.exercises
{
    public class NumerosPositivos
    {
        public static void postiveNumber()
        {
            int num = 0;
            int[] numerosPositivos = new int[10];
            int i = 0;

            while (i < numerosPositivos.Length)
            {
                Console.WriteLine("ingresa un numero positivo: ");
                num = int.Parse(Console.ReadLine());
                if (num > 0)
                {
                    numerosPositivos[i] = num;
                    i++;
                }
                else
                {
                    Console.WriteLine("ingresaste un numero negativo, intentalo de nuevo"); 
                }
            }
        }
    }
}
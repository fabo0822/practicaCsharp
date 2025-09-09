using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practicaCsharp.exercises
{
    public class Calculadora
    {
        public static void calculator()
        {
              double[] ventas = new double[5];
            int k = 0;
            int total = 0;
            System.Console.WriteLine("ingresa las 30 ventas del mes ");
            for (int i = 0; i < ventas.Length; i++)
            {
                Console.WriteLine("venta " + (i + 1));
                ventas[i] = double.Parse(Console.ReadLine());

            }
            Console.WriteLine("ventas iguales o superior a 1000");
            while (k < 5)
            {
                if (ventas[k] >= 1000)
                {
                    Console.WriteLine(ventas[k]);
                    total++;

                }
                k++;

            } 
           Console.WriteLine("cantidad de ventas igual o superiores a 1000 =" + total);


        }
    }
}
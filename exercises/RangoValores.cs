using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practicaCsharp.exercises
{
    public class RangoValores
    {
        public static void rangeValue()
        {
            int num = 0;
            int[] arr = new int[10];
            int i = 0;

            while (i < arr.Length)
            {

                Console.WriteLine("ingresa un numero entre 1 y 100 ");
                num = int.Parse(Console.ReadLine());
                if (num >= 1 && num <= 100)
                {
                    arr[i] = num;
                    i++;
                }
                else
                {
                    Console.WriteLine("numero ingresado fuera de rango. Ingrese otro numero ");
                }

            }
              Console.WriteLine("numeros ingresados en el arreglo");

            foreach (int temp in arr)
            {
                Console.WriteLine(temp);
            }
           
        }
    }
}
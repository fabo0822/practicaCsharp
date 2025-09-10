using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practicaCsharp.exercises
{
    public class ArreglosUnidos
    {
        public static void arrayUnite()
        {

            int[] array1 = new int[10];
            int[] array2 = new int[10];
            int[] array3 = new int[20];
            Console.WriteLine("introduce los numeros del array1: ");
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("introduce los numeros del array2: ");
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }
            int j = 0;
            Console.WriteLine("pasar array1 y array2 al array3: ");
            for (int i = 0; i < 10; i++)
            {
                array3[j] = array1[i];

                j++;
                array3[j] = array2[i];

                j++;
            }
            foreach (int i in array3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
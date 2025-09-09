using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practicaCsharp.exercises
{
    public class NumeroMaoyr
    {
        public static void largestNumber()
        {
             int[] arr = new int[5];
            int mayor = arr[0];// el numero mayor va a ser la posicion 0
            Console.WriteLine("ingresa 5 numeros en pantalla: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());// se va a ingresar los numeros i
                if (arr[i] > mayor) mayor = arr[i];
            }  
            Console.WriteLine($"el numero mayor del arreglo es : {mayor}");    
        }
    }
}
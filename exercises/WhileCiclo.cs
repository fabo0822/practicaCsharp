using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practicaCsharp.exercises
{
    public class WhileCiclo
    {
        public static void whileWithoutValidation()
        {
              int opcion, i=0;
            System.Console.WriteLine("elija una opcion: 1,-numeros del 0 al 100\n 2,- numeros del 100 al 0 ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1) {
                while (i <= 100)
                {
                    System.Console.WriteLine(i);
                    i++;
                }
                    //no hay validacion en este ejercicio
                } else {
                i = 100;
                while (i >= 0)
                {
                    System.Console.WriteLine(i);
                    i--;
                }
                }
        }
    }
}
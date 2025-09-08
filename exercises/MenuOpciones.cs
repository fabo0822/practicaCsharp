using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace practicaCsharp.exercises
{
    public class MenuOpciones
    {
        public static void mainOpcions()
        {
            string estadocivil;

            while (true)
            {

                System.Console.WriteLine("elija una opcion :");
                estadocivil = Console.ReadLine();



                switch (estadocivil)
                {
                    case "1":
                        System.Console.WriteLine("casado");
                        break;
                    case "2":
                        System.Console.WriteLine("soletero");
                        break;
                    case "3":
                        System.Console.WriteLine("divorsiado");
                        break;
                    case "4":
                        System.Console.WriteLine("viudo");
                        break;
                    case "x":
                        System.Console.WriteLine("saliendo del programa");
                        return;
                    default:
                        System.Console.WriteLine("la opcion no esta disponible");

                        break;
                }
            }

        }

    }
}    
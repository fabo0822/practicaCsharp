using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practicaCsharp.exercises
{
    public class CalcularCantidad
    {
        public static void calculateAmount()
        {
                        int canPiezas = 0;
            double totalPago = 0;
            Console.WriteLine("cuantas piezas comprara el cliente");
            canPiezas = int.Parse(Console.ReadLine());
            if (canPiezas > 50 && canPiezas <= 100)
            {
                totalPago = canPiezas * 4.5;
            }
            else if (canPiezas > 100)
            {
                totalPago = canPiezas * 4;
            }
            else
            {
                totalPago = canPiezas * 5;
            }
            Console.WriteLine($"el total a pagar por {canPiezas} es {totalPago}");
        }
    }
}
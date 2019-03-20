using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio23
    {
        public void Pagar()
        {
            double pre, cant,total,totalD;

            Console.WriteLine("Ingrese el precio total de la compra");
            pre = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad de productos a comprar");
            cant = double.Parse(Console.ReadLine());
            total=pre*cant;
            if (total >= 100000)
            {
                totalD = total * 0.80;
                Console.WriteLine("El total de la compra con descuento 20% es: " + totalD);
            }
            else
            {
                Console.WriteLine("El total de la compra es: " + total);
 
            }

        }
    }
}

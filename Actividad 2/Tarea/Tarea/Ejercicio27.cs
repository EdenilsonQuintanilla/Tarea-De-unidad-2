/*27. Programa que permita determinar el total a pagar
por una compra del la cual se sabe el valor
unitario y la cantidad. Se debe tener en cuenta
que se realiza un descuento del 15% por compra
inferiores a $20000 y del 35% por compras
mayores o iguales a $20000.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio27
    {
        public void TotalPagar()
        {
 
            double Total, precio, cant;
            Console.WriteLine("Ingrese cantidad del producto");
            cant = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese precio del producto");
            precio = double.Parse(Console.ReadLine());

            if (precio < 20000)
            {
                Total = (precio * cant) * (0.85);
                Console.WriteLine("Su descuento aplicando 15% es : " + Total);
            }
            else 
            {
                Total = ((precio * cant) * (0.65));
                Console.WriteLine("Su descuento aplicando 35% es: " + Total);
            }

        }
    }
}

/*
30. Programa que permita calcular el valor final a
pagar en una súper tienda en donde se aplican los
siguientes descuentos:
a) Por compras entre 10000 y 20000 el 10%
b) Por compras entre 20001 y 50000 el 30%
c) Por compras superiores a 50000 el 50%
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio30
    {
        public void ValFinal()
        {
            double Val,Val1,Val2,Val3;
            Console.WriteLine("Ingrese valor final de la compra");
            Val = double.Parse(Console.ReadLine());

            if (Val > 10000 && Val < 20000)
            {
                Val1 = Val * 0.90;
                Console.WriteLine("Total de compra, mas descuento del 10% es: "+Val1);
            }
            else if (Val > 20001 && Val < 50000)
            {
                Val2 = Val * 0.70;
                Console.WriteLine("Total de compra, mas descuento del 30% es: " + Val2);
            }
            else if (Val > 50001)
            {
                Val3 = Val * 0.50;
                Console.WriteLine("Total de compra, mas descuento del 50% es: " + Val3);
            }
        }
    }
}

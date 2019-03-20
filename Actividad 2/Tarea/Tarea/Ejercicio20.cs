/*
20. Programa para determinar la mitad de un número
ingresado por el usuario es mayor o menor de 100.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio20
    {
        public void NumEva()
        {
            double numero, mitad;

            Console.Write("Ingrese un numero para evaluar: ");
            numero = Convert.ToDouble(Console.ReadLine());

            mitad = numero / 2;

            if (mitad > 100)
            {
                Console.WriteLine("El La mitad del numero ingresado es " + mitad + " y es mayor que 100");
            }
            else
            {
                Console.WriteLine("El La mitad del numero ingresado es " + mitad + " y es menor que 100");

            }

            Console.ReadKey();
        }
    }
}

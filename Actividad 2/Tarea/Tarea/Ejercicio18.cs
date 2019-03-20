/*
18. Programa para determinar cuál es mayor entre 2
números cualquiera ingresados por el usuario
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio18
    {
        public void Evaluar()
        {
            int num1, num2;

            Console.Write("Ingrese el primer numero para evaluar: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo numero para evaluar: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("El numero mayor es " + num1);
            }
            else
            {
                Console.WriteLine("El numero mayor es " + num2);
            }

            Console.ReadKey();
        }
    }
}

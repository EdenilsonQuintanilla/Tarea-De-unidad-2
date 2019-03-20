/*
28. Programa para determinar si un número cualquiera
ingresado por el usuario es par o impar.(Usar
operación Modulo)
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio28
    {
        public void ParImparMod()
        {
            int num;
            Console.WriteLine("Ingrese un numero");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("El numero ingresado es PAR");    
            }
            else
            {
                Console.WriteLine("El numero ingresado es IMPAR");
            }
        }

    }
}

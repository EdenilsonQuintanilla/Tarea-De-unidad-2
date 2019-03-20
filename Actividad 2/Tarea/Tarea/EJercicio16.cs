/*
17. Programa para determinar si un número cualquiera
ingresado por el usuario es o no positivo
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio16
    {
        public void NumerosCualquiera()
        {
             double numero;

            Console.Write("Ingrese un numero cualquiera: ");
            numero = Convert.ToDouble(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("El numero ingresado es un numero positivo");
            }
            else
            {
                Console.WriteLine("El numero ingresado es negativo");
            }

            Console.ReadKey();
        }
        }
    }


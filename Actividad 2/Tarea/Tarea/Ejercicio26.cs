/*
26. Se ingresa por teclado un número positivo de uno
o dos dígitos (1..99) mostrar un mensaje
indicando si el número tiene uno o dos dígitos.
(Tener en cuenta que condición debe cumplirse
para tener dos dígitos, un número entero
*/ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio26
    {
        public void UnoDos()
        {
            int num;
            Console.WriteLine("Ingrese un numero del 1 al 99");
            num = int.Parse(Console.ReadLine());

            if (num >= 1 && num <= 9)
            {
                Console.WriteLine("El numero ingresado tiene 1 DIGITO");
            }
            else if (num >=10 && num <=99)
            {
                Console.WriteLine("El numero ingresado tiene 2 DIGITO");
            }
        }
    }
}

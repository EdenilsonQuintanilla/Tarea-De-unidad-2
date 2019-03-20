/*
Realizar un programa que lea por teclado 2 numeros, si el primero es mayor al segundo informa suma y diferencia
En caso contrario informar el producto y la division del primero respecto al segundo
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio24
    {
        public void Ope2()
        {
            double num1, num2, Resultado1, Resultado2,Resultado3;
            Console.WriteLine("Ingrese primer numero");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo numero");
            num2 = double.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Resultado1 = num1 + num2;
                Resultado2 = num2 - num1;
                Console.WriteLine("La suma de los 2 numeros es: " + Resultado1);
                Console.WriteLine("La diferencia entre los numeros es: " + Resultado2);
            }
            else
            {
                Resultado3 = num1 / num2;
                Console.WriteLine("La division entre los numeros es: " + Resultado3);
            }
        }
    }
}

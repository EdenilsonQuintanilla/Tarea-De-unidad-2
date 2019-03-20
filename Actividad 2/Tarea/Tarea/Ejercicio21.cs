/*
21. Programa en el cual se ingresen 2 números y
luego realice las siguientes operaciones:
a) Si los números son iguales restarlos
b) Si los números son diferentes sumarlos
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio21
    {
        public void SuRE()
        {
            double num1, num2;
            double resta, suma;

            Console.Write("Ingrese el primer numero a evaluar: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el segundo numero a evaluar: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            if (num1 == num2)
            {
                resta = num1 - num2;
                Console.WriteLine("Los numeros son iguales se prodecedera a restar");
                Console.WriteLine("La resta es de: " + resta);
            }
            else
            {
                suma = num1 + num2;
                Console.WriteLine("Los numeros son diferentes se prodecedera a sumar");
                Console.WriteLine("La suma es de: " + suma);
            }

            Console.ReadKey();
        }
    }
}

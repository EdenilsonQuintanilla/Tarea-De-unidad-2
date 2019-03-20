/*
29. Programa el cual permita ingresar los valores de
temperatura de cada día durante una semana. Le
programa debe calcular la temperatura promedio y
luego mostrar los siguientes mensajes:
a) Si el promedio es mayor a 35° mostrar el
mensaje “Que semana tan calurosa”
b) Si el promedio esta entre 15° y 35° mostrar
el mensaje “Que clima tan delicioso”
c) Si el promedio es menor de 15° mostrar el
mensaje “Que semana tan fría”
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio29
    {
        int temperatura,d1,d2,d3,d4,d5,d6,d7;
        public void Temperatura()
        {
            Console.WriteLine("Ingrese temperatura del dia Lunes");
            d1=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese temperatura del dia Martes");
            d2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese temperatura del dia Miercoles");
            d3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese temperatura del dia Jueves");
            d4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese temperatura del dia Viernes");
            d5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese temperatura del dia Sabado");
            d6 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese temperatura del dia Domingo");
            d7 = int.Parse(Console.ReadLine());

            temperatura = (d1 + d2 + d3 + d4 + d5 + d6 + d7) / 7;

            if (temperatura > 35)
            {
                Console.WriteLine("Que semana tan calurosa");
            }
            else if  (temperatura>15 && temperatura<34)
            {
                Console.WriteLine("Que clima tan calido");
            }
            else if (temperatura < 14)
            {
                Console.WriteLine("Que semana tan fria");
            }
 
        }

    }
}

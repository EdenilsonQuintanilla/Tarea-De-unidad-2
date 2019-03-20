using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio69
    {
        public void e69()
        {
            string[] nombres;
            string[] apellidos;

            nombres = new string[26];
            apellidos = new string[26];

            for (int i = 1; i < 26; i++)
            {
                Console.WriteLine("Ingrese el " + i + ") nombre: ");
                nombres[i] = Console.ReadLine();

            }
            Console.WriteLine("");
            for (int i = 1; i < 26; i++)
            {
                Console.WriteLine("Ingrese el " + i + ") apellido: ");
                apellidos[i] = Console.ReadLine();

            }
            for (int i = 1; i < 26; i++)
            {
                Console.WriteLine("acontinuacion se mostraran el apellido y el nombre ");
                Console.WriteLine(nombres[i] + " " + apellidos[i]);

            }

            Console.ReadKey();

        }
    }
}

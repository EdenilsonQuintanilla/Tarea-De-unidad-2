using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio60
    {
        public void nombres ()
        {

               string[] nombres;

            nombres = new string[15];

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Ingrese el nombre: ");
                nombres[i] = Console.ReadLine(); 
            }
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("Los nombres ingresados son: ");
                Console.WriteLine(nombres[i]);
            }
                Console.ReadKey();
        }
    }
}



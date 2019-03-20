using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio41
    {
        public void edadpromedio()
        {
            int i, edad = 0, prom = 0, S;


            for (i = 1; i <= 15; i++)
            {
                Console.WriteLine("Ingrese su Edad");
                edad = Convert.ToInt16(Console.ReadLine());
                if (edad > 0)
                {
                    
                       S = edad + edad;

                    prom = S / 15;
                }

            }
            Console.WriteLine("El promedio de edad de los alumnos es: " + prom);

        }
    }
}

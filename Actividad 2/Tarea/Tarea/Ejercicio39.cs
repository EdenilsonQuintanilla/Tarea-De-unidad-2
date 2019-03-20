using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio39
    {
        public void Mayor()
        {
            int i, edad, edadM = 0;

       
            for (i = 1; i <= 20; i++)
            {
                Console.WriteLine("Ingrese Edad");
                edad = int.Parse(Console.ReadLine());
                if (edad > 18)
                {
                    edadM = edadM + 1;

                }
                
            }
            Console.WriteLine("la cantidad de alumnos mayores de edad son: " + edadM);
        }
    }
}

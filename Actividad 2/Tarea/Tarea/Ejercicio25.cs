using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio25
    {
        public void Promocionado()
        {
            int n1, n2, n3, promedio;

            Console.WriteLine("Ingrese nota 1 del estudiante");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese nota 2 del estudiante");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese nota 3 del estudiante");
            n3 = int.Parse(Console.ReadLine());

            promedio = (n1 + n2 + n3) / 3;

            if (promedio >= 7)
            {
                Console.WriteLine("Su promedio es: "+promedio+" Promocionado");
            }
            else
            {
                Console.WriteLine("Su promedio es: " + promedio + " No Promocionado");
            }
        }
    }
}

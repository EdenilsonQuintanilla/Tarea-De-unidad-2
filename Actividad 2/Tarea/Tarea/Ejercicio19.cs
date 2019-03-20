/*
19. Programa para saber si un estudiante del Enrique
Olaya Herrera requiere refrigerio. Por disposición
de la Secretaria de Educación requieren refrigerio
los estudiantes de grado sexto hacia abajo.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio19
    {
        public void Grado()
        {
            int grado;
            Console.Write("Ingrese a que grado pertenece(en numero): ");
            grado = Convert.ToInt32(Console.ReadLine());

            if (grado < 6)
            {
                Console.WriteLine("Si tiene acceso al refrigerio");
            }
            else
            {
                Console.WriteLine("No tiene acceso al refrigerio");

            }

            Console.ReadKey();
        }
    }
}

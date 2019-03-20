/*
22. Programa en el cual reciba como entradas la
siguiente información: Código del Estudiante,
Nombre del Estudiante, Nombre de la Materia
Tres Notas de 1.0 a 5.0. Con esta información
el programa debe calcular la nota definitiva
(promedio) y determinar si el estudiante aprueba
o no la materia (Definitiva mayor a 4.0). Debe
imprimir coma salidas el nombre, el código, la
materia y si aprobó o no.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio22
    {
        
        string nom, mat;
        double cod,n1,n2,n3,promedio;

        public void Notas()
        {
            Console.WriteLine("Ingrese el codigo del estudiante");
            cod = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre del estudiante");
            nom = (Console.ReadLine());
            Console.WriteLine("Ingrese el nombre de la materia");
            mat = (Console.ReadLine());
            Console.WriteLine("Ingrese nota 1 del estudiante");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese nota 2 del estudiante");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese nota 3 del estudiante");
            n3 = int.Parse(Console.ReadLine());

            promedio = (n1 + n2 + n3) / 3;

            if (promedio >= 4)
            {
                Console.WriteLine(nom + " " + cod + " " + mat + " " + "Su promedio es: " + promedio + " y usted Aprobo");
            }
            else
            {
                Console.WriteLine(nom + " " + cod + " " + mat + " " + "Su promedio es: " + promedio + " y usted Reprovo");
            }

        }
    }
}

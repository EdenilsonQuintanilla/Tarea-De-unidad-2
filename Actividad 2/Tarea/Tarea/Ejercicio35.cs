using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio35
    {
        public void alumno()
        {
            double n1, n2, n3, suma, prom;
            int año, edad;

            Console.WriteLine("Selecione Menu"+
            "\n1. Pasa o no la materia? "+
           "\n2. Es mayor o menor de edad?");

            int alum = Convert.ToInt32(Console.ReadLine());

            switch(alum)
            {
                case 1:
                    {
                        Console.WriteLine("Ingrese nota 1 ");
                        n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese nota 2 ");
                        n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese nota 3 ");
                        n3 = int.Parse(Console.ReadLine());

                        suma = n1 + n2 + n3;
                        prom = suma / 3;

                        if(prom>3)
                        {
                            Console.WriteLine("Alumno Aprobado");
                        }
                        else
                        {
                            Console.WriteLine("Alumno Reprobado");
                        }
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Digite su año de nacimiento");
                        año = int.Parse(Console.ReadLine());

                        edad = DateTime.Today.Year - año;

                        Console.WriteLine("Su edad es: " + edad );
                    }
                    break;

            }



        }
    }
}

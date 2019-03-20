using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio68
    {
        public void e68()
        {
                        int[] salones;
            int Nsalones;
            int mayor =0, menor= 0;

            Console.WriteLine("Ingrese la cantidad de Salones: ");
            Nsalones = int.Parse(Console.ReadLine());
            Nsalones = Nsalones + 1;

            salones = new int[Nsalones];

            for (int i = 1; i < Nsalones; i++)
            {
                Console.WriteLine("Ingrese el total de estudiantes ingresados en el aula N " + i + " :");
                salones[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("");
            for (int i = 1; i < salones.Length; i++)
            {
                if (salones[i] > mayor)
                { 
                    mayor = salones[i];
                }
                else if (salones[i] < menor)
                {
                    menor = salones[i];
                }
            }
            Console.WriteLine("El salon con mayor numero de alumnos es: ");
            Console.WriteLine(mayor);

            Console.ReadKey();

        }
    }
}

       
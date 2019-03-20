using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio31
    {
        public void Evaluacion()
        {
            int edad;
            double estatura=0.0, peso=0.0;

            Console.WriteLine("Ingrese edad");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese estatura en centimetros");
            estatura = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese peso en kilogramos");
            peso = double.Parse(Console.ReadLine());

            if((edad>=18)&&(estatura>180)&&(peso<=80))
            {
                Console.WriteLine("El aspirante es Aceptado");
            }
            else
            {
                Console.WriteLine("El aspirante no es aceptado");
            }

        }
    }
}

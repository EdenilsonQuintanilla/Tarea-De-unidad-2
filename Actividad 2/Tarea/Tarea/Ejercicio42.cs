using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio42
    {
        public void estaturapromedio()
        {
            int  estatura = 0, prom = 0, acumulador=0;


            for (int i = 1; i <= 18; i++)
            {
                Console.WriteLine("Ingrese su Edad en centimetros");
                estatura = Convert.ToInt16(Console.ReadLine());
                acumulador = acumulador + estatura;
             }
            prom = acumulador / 18;
            Console.WriteLine("El promedio de edad de los alumnos es: " + prom);
            if (prom < 140 )
            Console.WriteLine("Los alumnos son muy bajos de estatura: " );
            if (prom >= 140 && prom <= 170)
                Console.WriteLine("Los alumnos Son de estatura normal: " );
            if (prom > 170)
                Console.WriteLine("Los alumnos son muy Altos de estatura: ");

        }
    }
}

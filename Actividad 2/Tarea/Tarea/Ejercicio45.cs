using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio45
    {
        public void multiplo5()
        {
            int i;


            for (i = 5; i <= 100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine("Los numeros multiplos de 5 son " + i);
                }
            }
        }
    }
}

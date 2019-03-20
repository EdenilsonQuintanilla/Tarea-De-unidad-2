using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio37
    {
        public void npar()
        {
            int i;


            for (i = 0; i <= 200; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Los numeros pares son " + i);
                }
            }
        }
    }
}

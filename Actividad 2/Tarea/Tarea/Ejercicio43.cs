using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio43
    {
        public void multiplo3()
        {
            int i;


            for (i = 3; i <= 99; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("Los numeros multiplos de 3 son " + i);
                }
            }
        }
    }
}

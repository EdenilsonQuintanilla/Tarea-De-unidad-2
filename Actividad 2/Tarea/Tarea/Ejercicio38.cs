using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio38
    {
        public void impar()
        {
            int i;


            for (i = 201; i <= 499; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine("Los numeros impares son " + i);
                }
            }
        }
    }
}

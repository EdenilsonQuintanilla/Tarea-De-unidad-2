using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio44
    {
        public void tablamulti()
        {
            int i,n;
            Console.Write("Digite el valor de N: ");
            n = Convert.ToInt16(Console.ReadLine());

            for (i = 0; i <= 10; i++)
            {
              
                    Console.WriteLine("{0}  x {1} = {2}",n,i, (n*i));
            }
        }
    }
}

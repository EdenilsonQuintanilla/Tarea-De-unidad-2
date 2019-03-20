using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio64
    {
        public void e64()
        {
             double[] valores;
            

            valores = new double[19];

            for (int i = 1; i < 19; i++)
            {
                Console.WriteLine("Ingrese el valor del dato: ");
                valores[i] = double.Parse(Console.ReadLine());
                
            }
            Console.WriteLine("");
            for (int i = 18;i>0 ; i--)
            {
                
                Console.WriteLine(valores[i]);

            }

                Console.ReadKey();
        }
    }
}


        }

    }
}

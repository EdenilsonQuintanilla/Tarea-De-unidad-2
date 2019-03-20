using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio61
    {
        public void sumanum()
                    {
            double[] valores;
            double total=0;

            valores = new double[12];

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("Ingrese el valor a sumar: ");
                valores[i] = double.Parse(Console.ReadLine());
                
            }
            
            for (int i = 0; i < valores.Length;i++ )
            {
                total = valores[i]+total;
            }
            Console.WriteLine("La suma total de los numeros es: ");
            Console.WriteLine(total);

            Console.ReadKey();
        }
    }
}

    }
}

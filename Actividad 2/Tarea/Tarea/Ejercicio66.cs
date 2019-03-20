using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio66
    {
        public void e66()
        {
            double[] valores;
            double[] valores1;
            double[] suma;
            double[] resta;

            resta = new double[12];
            suma = new double[12];
            valores = new double[12];
            valores1 = new double[12];
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("Ingrese los datos");
                valores[i] = double.Parse(Console.ReadLine());
                
            }
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("Ingrese la segunda fila de datos");
                valores1[i] = double.Parse(Console.ReadLine());

            }
            Console.WriteLine("");
            for (int i = 0; i < 12; i++)
            {

                suma[i] = valores[i] + valores1[i];
                Console.WriteLine("La suma "+i+" es: "+suma[i]);

            }
            Console.WriteLine("");
            for (int i = 0; i < 12; i++)
            {

                resta[i] = valores[i] - valores1[i];
                Console.WriteLine("La resta " + i + " es: " + resta[i]);
            }
            

                Console.ReadKey();
        }
    }
}

       
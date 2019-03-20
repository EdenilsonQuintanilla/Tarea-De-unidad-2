using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio67
    {
        public void e67()
        {
                        double[] valores1;
            double[] valores2;
            double[] valores3;
            int datos;
            

            Console.WriteLine("Ingrese el total de posiciones que quiere almacenar:");
            datos = int.Parse(Console.ReadLine());
            datos = datos + 1;

            valores3 = new double[datos];
            valores2 = new double[datos];
            valores1 = new double[datos];
            for (int i = 1; i < datos; i++)
            {
                Console.WriteLine("Ingrese los valores");
                valores1[i] = double.Parse(Console.ReadLine());
                
            }
            for (int i = 1; i < datos; i++)
            {
                valores2[i] = Math.Pow(valores1[i], 2);

            }
            Console.WriteLine("");
            for (int i = 1; i < datos; i++)
            {
                valores3[i] = Math.Pow(valores1[i], 3);

            }
            Console.WriteLine("");
            for (int i = 1; i < datos; i++)
            {
                Console.WriteLine(i+") posicion del valor");
                Console.WriteLine("Valor ingresado: "+valores1[i]);
                Console.WriteLine("Cuadrado del valor: "+valores2[i]);
                Console.WriteLine("Cubo del valor: "+valores3[i]);
            }
            

                Console.ReadKey();
        }
    }
}

        
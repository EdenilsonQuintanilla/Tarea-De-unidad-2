using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio71
    {
        public void e71()
        {
                        double[,] numeros;
            double suma=0, promedio=0;

            numeros = new double[3, 4];
            

            for (int fila = 0; fila < 3; fila++)
            {
                for (int colum = 0; colum < 4;colum++ )
                {
                    Console.WriteLine("Ingrese un valor: ");
                    numeros[fila, colum] = double.Parse(Console.ReadLine());

                }

            }
            
            for (int fila = 0; fila < 3; fila++)
            {
                for (int colum = 0; colum < 4; colum++)
                {
                   suma = suma+numeros[fila,colum];
                   promedio = suma / (3 * 4);
                }
                Console.WriteLine();
            }

            Console.WriteLine("La suma de todos los valores es : ");
            Console.WriteLine(suma);
            Console.WriteLine("el promedio es : ");
            Console.WriteLine(promedio);

            Console.ReadKey();


        }
    }
}

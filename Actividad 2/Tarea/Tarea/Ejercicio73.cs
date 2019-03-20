using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio73
    {
        public void e73()
        {
            int[,] numeros;
            int nfilas, ncolum, contarP = 0, contarN = 0, negativos = 0;

            Console.WriteLine("Ingrese el numero de filas de la matriz: ");
            nfilas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de columnas de la matriz: ");
            ncolum = int.Parse(Console.ReadLine());

            numeros = new int[nfilas, ncolum];

            for (int fila = 0; fila < nfilas; fila++)
            {
                for (int colum = 0; colum < ncolum; colum++)
                {
                    Console.WriteLine("Ingrese un valor entero: ");
                    numeros[fila, colum] = int.Parse(Console.ReadLine());

                }

            }

            for (int fila = 0; fila < nfilas; fila++)
            {
                for (int colum = 0; colum < ncolum; colum++)
                {
                    if (numeros[fila, colum] > 0)
                    {
                        contarP = contarP + 1;
                    }
                    else if (numeros[fila, colum] < 0)
                    {
                        contarN = contarN + 1;
                    }
                    else if (numeros[fila, colum] == 0)
                    {
                        negativos = negativos + 1;
                    }

                }

            }
            Console.WriteLine("El total de numeros positivos es: ");
            Console.WriteLine(contarP);
            Console.WriteLine("El total de numeros negativos es: ");
            Console.WriteLine(contarN);
            Console.WriteLine("El total de ceros es: ");
            Console.WriteLine(negativos);

            Console.ReadKey();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio74
    {
        public void e74()
        {
            int[,] numeros;
            int nfilas, ncolum, val1 = 0;

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
            Console.WriteLine("Ingrese el numero a buscar:");
            val1 = int.Parse(Console.ReadLine());

            for (int fila = 0; fila < nfilas; fila++)
            {
                for (int colum = 0; colum < ncolum; colum++)
                {

                    if (val1 == numeros[fila, colum])
                    {
                        Console.WriteLine("El vector esta en la posicion (" + fila + "," + colum + ")");
                    }

                }

            }


            Console.ReadKey();

        }
    }
}

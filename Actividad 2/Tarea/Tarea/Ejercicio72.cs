using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio72
    {
        public void e72()
        {
            int[,] numeros;
            int nfilas, ncolum, val1, val2;

            Console.WriteLine("Ingrese el numero de filas de la matriz: ");
            nfilas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de columnas de la matriz: ");
            ncolum = int.Parse(Console.ReadLine());

            numeros = new int[nfilas, ncolum];

            for (int fila = 0; fila < nfilas; fila++)
            {
                for (int colum = 0; colum < ncolum; colum++)
                {
                    Console.WriteLine("Ingrese un valor: ");
                    numeros[fila, colum] = int.Parse(Console.ReadLine());

                }

            }

            do
            {
                Console.WriteLine("Ingrese el numero de fila que quiere ver:");
                val1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el numero de columnaque quiere ver:");
                val2 = int.Parse(Console.ReadLine());
                if (val1 < nfilas && val2 < ncolum)
                {
                    Console.WriteLine("El vector (" + val1 + "," + val2 + ") contiene: " + numeros[val1, val2]);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Adios");
                }
            } while (val1 < nfilas && val2 < ncolum);


            Console.ReadKey();

        }
    }
}

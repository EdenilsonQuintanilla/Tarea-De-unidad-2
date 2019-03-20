using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio70
    {
        public void e70()
        {
            int[,] numeros;
            int nfilas, ncolum;
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

            for (int fila = 0; fila < nfilas; fila++)
            {
                for (int colum = 0; colum < ncolum; colum++)
                {
                    Console.WriteLine("posicion " + fila + "," + colum + " tiene");
                    Console.WriteLine(" " + numeros[fila, colum]);
                }
                Console.WriteLine();
            }


            Console.ReadKey();

        }
    }
}

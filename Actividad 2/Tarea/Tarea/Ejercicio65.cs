using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio65

    {
        public void e65()
        {
                        int[] valores;
            int mes;
            int clientes = 0;
            Console.WriteLine("Ingrese la cantidad de dias del mes: ");
            mes = int.Parse(Console.ReadLine());
            mes = mes + 1;

            valores = new int[mes];

            for (int i = 1; i < mes; i++)
            {
                Console.WriteLine("Ingrese el total de clientes ingresados el dia : "+i+" de este mes");
                valores[i] = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine("");
            for (int i = 1; i < valores.Length; i++)
            {

                clientes = valores[i] + clientes;

            }
            Console.WriteLine("El total de clientes atendidos este mes es: ");
            Console.WriteLine(clientes);

                Console.ReadKey();
        }
    }
}

        
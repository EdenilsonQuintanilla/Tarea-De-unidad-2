using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio34
    {
        public void numero()
        {
            int n = 0;

            Console.WriteLine("Selecione Menu");
            Console.WriteLine("1. Determinar si es positivo o negativo");
            Console.WriteLine("2. Determinar si es par o impar");

            int num = Convert.ToInt32(Console.ReadLine());


            switch (num)
            {

                case 1:
                    {
                        Console.WriteLine("Digite numero");
                        n = Convert.ToInt32(Console.ReadLine());

                        if (n > 0)
                        {
                            Console.WriteLine("El numero ingresado es positivo");

                        }
                        else
                        {
                            Console.WriteLine("El numero ingresado es negativo");
                        }

                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Digite numero");
                        n = Convert.ToInt32(Console.ReadLine());

                        if (n%2 ==0)
                        {
                            Console.WriteLine("El numero ingresado es par");

                        }
                        else
                        {
                            Console.WriteLine("El numero ingresado es impar");
                        }
                    }
                    break;
            }

        }

    }
}

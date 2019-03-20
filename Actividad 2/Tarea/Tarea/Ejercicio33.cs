using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio33
    {
        public void calculo()
        {
            double x = 0.0, v = 0.0, t = 0.0;

            Console.WriteLine("Selecione Menu");
            Console.WriteLine("1. Calcular Distancia");
            Console.WriteLine("2. Calcular Velocidad");
            Console.WriteLine("3. Calcular Tiempo");

            int calcu;
            calcu = Convert.ToInt32(Console.ReadLine());
           

            switch(calcu)
            {
                case 1:
                    {
                        Console.WriteLine("Ingrese Velocidad");
                        v = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese tiempo");
                        t = double.Parse(Console.ReadLine());
                        x = v * t;
                      

                        Console.WriteLine("La distancia es : "+ x + "km");
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Ingrese Distancia");
                        x = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese tiempo");
                        t = double.Parse(Console.ReadLine());
                        v = x/t;

                        Console.WriteLine("La velocidad es : " + v + "km/h");
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Ingrese Distancia");
                        x = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese velocidad");
                        v = double.Parse(Console.ReadLine());
                        t = x/v;

                        Console.WriteLine("LEl tiempo es : " + t + "h");
                    }
                    break;

            }
        }
    }
}

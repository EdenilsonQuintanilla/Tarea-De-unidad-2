using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio63
    {
        public void valordato()
        {
                        double[] valores;
            int val;

            valores = new double[21];

            for (int i = 1; i < 21; i++)
            {
                Console.WriteLine("Ingrese el valor del dato: ");
                valores[i] = double.Parse(Console.ReadLine());
                
            }
            
           
           do{
               Console.WriteLine("Ingrese el numero del vector que quiere observar");
               val = int.Parse(Console.ReadLine());
               if (val < 21)
               {
                   Console.WriteLine("El vector " + val + " contiene: " + valores[val]);
               }
            }while(val < 21);
            

            Console.ReadKey();
        }
    }
}

    


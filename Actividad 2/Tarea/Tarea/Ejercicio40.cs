using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio40
    {
        public void sexo()
        {


        
            int i, cv=0, cm=0,S ;

       
            for (i = 1; i <= 25; i++)
            {
                 Console.WriteLine("Ingrese su sexo");
                 Console.WriteLine("0. Femenino");
                 Console.WriteLine("1. masculino");
                    S = Convert.ToInt16(Console.ReadLine());
                    if(S==1)
                    {
                        cv++;
                     }
                    else
                    {
                       cm++;
                     }
                
            }
            Console.WriteLine("la cantidad de estudiantes mujeres son: " + cm);
            Console.WriteLine("la cantidad de estudiantes mujeres son: " + cv);
        }

        }


}
        
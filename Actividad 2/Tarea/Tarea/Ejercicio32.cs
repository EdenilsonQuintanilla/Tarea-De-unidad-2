using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio32
    {
        public void Letra()
        {
            string Letra1;
            Console.WriteLine("Ingrese la Letra a Evaluar en minuscula");
            Letra1 =(Console.ReadLine().ToLower());

            switch(Letra1)
            {
                case "a":
                    {
                        Console.WriteLine("La letra es vocal");
                    }
                break;
                case "e":
                    {
                         Console.WriteLine("La letra es vocal");
                     }
                break;
                case "i":
                    {
                        Console.WriteLine("La letra es vocal");
                    }
                break;
                case "o":
                    {
                        Console.WriteLine("La letra es vocal");
                    }
                break;
                case "u":
                    {
                        Console.WriteLine("La letra es vocal");
                    }
                break;
                default:
                    {
                        Console.WriteLine("La letra es consonante");
                    }
                break;
            }

           
        }
     
      

    }
}

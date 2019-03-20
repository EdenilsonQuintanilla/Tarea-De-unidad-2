/*
17. Programa que determine si una persona es mayor
de edad o no teniendo en cuenta el año actual y su
año de nacimiento
*/ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio17
    {
        public void Nacimiento()
        {
        
            int nacimiento;
            Console.Write("Ingrese el año de nacimiento: ");
            nacimiento = Convert.ToInt32(Console.ReadLine());

            int totalyear = (System.DateTime.Now.Year - nacimiento)-1;

            if (totalyear >= 18)
            {
                Console.WriteLine("Usted es mayor de edad");
                Console.WriteLine("Su edad es de: " + totalyear);
            }
            else
            {
                Console.WriteLine("Usted no es mayor de edad");
                Console.WriteLine("Su edad es de: " + totalyear);
            }
            
         
            Console.ReadKey();
        }
    }
}

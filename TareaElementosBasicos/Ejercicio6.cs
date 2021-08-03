using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaElementosBasicos
{
    class Ejercicio6
    {
        /*Crear un programa que calcule la nota de un estudiante en base a 3 notas ingresadas,
         cada nota equivale a 30%, 35%, y 25%, deberá mostrar las notas ingresadas, notas con 
        el porcentaje aplicado y la nota final.*/

        static void Main(string[] args)
        {
            double not1, not2, not3, porcent1, porcent2, porcent3, notfinal;

            Console.WriteLine("Bienvenido a nuestro Sistema, vamos a calcular tus notas. ");
            Console.WriteLine("Suerte...");

            Console.WriteLine("Ingresa tu primer nota (equivale al 30%): ");
            not1 = int.Parse(Console.ReadLine());
            porcent1 = (not1 * 0.30);
            Console.WriteLine("Nota ingresada: {0}", not1);
            Console.WriteLine("Porcentaje de la nota: {0} ", porcent1);
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("Ingresa tu segunda nota (equivale al 35%): ");
            not2 = int.Parse(Console.ReadLine());
            porcent2 = (not2 * 0.35);
            Console.WriteLine("Nota ingresada: {0}", not2);
            Console.WriteLine("Porcentaje de la nota: {0} ", porcent2);
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("Ingresa tu tercera nota (equivale al 25%): ");
            not3 = int.Parse(Console.ReadLine());
            porcent3 = (not3 * 0.25);
            Console.WriteLine("Nota ingresada: {0}", not3);
            Console.WriteLine("Porcentaje de la nota: {0} ", porcent3);
            Console.WriteLine("-------------------------------------------");

            notfinal = (porcent1 + porcent2 + porcent3);
            Console.WriteLine("Su nota final es de: {0}", notfinal);
            Console.WriteLine("Gracias por usas nuestro sistema para calcular tus notas. Buen dia.");

            Console.ReadKey();

        }

    }
}

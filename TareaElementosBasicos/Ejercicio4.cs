using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaElementosBasicos
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            //Se declaran las variables
            double cent, far;

            //Se ingresan los datos
            Console.WriteLine("Ingrese los grados que convertir: ");
            cent = Convert.ToDouble(Console.ReadLine());

            //Se hace la conversion 
            far = (9 / 5) * cent + 32;

            // Salida de los datos
            Console.WriteLine("En grados Fahrenheit sus grados centigrados son: {0} ", far);

            Console.ReadKey();
        }

       

          

    }
}

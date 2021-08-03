using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaElementosBasicos
{
    class Ejercicio3
    {
        static void Main(string[] args)
        {

            /*Se pide que:
            Crear un programa que pida al usuario dos números enteros. Si el segundo no es cero, 
            mostrará el resultado de dividir entre el primero y el segundo. Por el contrario, 
            si el segundo número es cero, escribirá "Error: No se puede dividir entre cero".*/


            Int32 numero1, numero2;
            Console.WriteLine("Proporcione un numero entero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Proporcione un numero entero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            double result;
                if (numero2 != 0)
            {
                result = (numero1 / numero2);
                Console.WriteLine("El resultado de esta division es: {0}", result);


            }
                if (numero2 == 0 )
            {
                Console.WriteLine("Error. NO se puede dividir entre cero");

            }

            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaElementosBasicos
{
    class Ejercicio2
    {
        static void Main(String []args)
        {
            int num1, num2, result;
            String Linea;
            {
                Console.Write("Ingrese Primer Nuemro: ");
                Linea = Console.ReadLine();
                num1 = int.Parse(Linea);

                Console.Write("Ingrese Segundo Numero: ");
                Linea = Console.ReadLine();
                num2 = int.Parse(Linea);

                Console.WriteLine();
                result = num1 + num2;
                Console.WriteLine("La suma seria {0}: ", result);

                result = num1 - num2;
                Console.WriteLine("La resta seria: {0} - {1} = {2}", num1, num2, result);
                Console.Write("Pulse una tecla: "); Console.ReadLine();
                Console.ReadKey();
            }
            
        }
    }
}

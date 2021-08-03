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

            /*Se pide:
            Solicitar a un usaurio dos valores (a y b), y el programa mostrará el
            resultado de la operación (a+b)*(a-b) y el resultado de la operación a2-b*/


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
                Console.ReadLine();

                Console.WriteLine("Primera Operacion (a + b) * (a - b)");
                result = (num1 + num2) * (num1 - num2);
                Console.WriteLine("La respuesta sera: ({0} + {1}) * ({2} - {3}) = {4}", num1, num2, num1, num2, result);

                Console.WriteLine("Segunda Operacion a2 - b");
                result = (num1 * 2) - num2;
                Console.WriteLine("La respuesta de la segunda Operacion es: {0}({1}) - {2} = {3}",num1, 2, num2, result);

                Console.ReadKey();
            }
            
        }
    }
}

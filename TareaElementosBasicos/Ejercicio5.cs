using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaElementosBasicos
{
    class Ejercicio5
    {
        static void Main(string[] args)
        {
            /*Hacer un programa que calcule el impuesto de un producto, pero 
             coloque un impuesto del 0% si el producto es medicina.*/


            int nuProd;
            Console.WriteLine("Categoria de Productos segun numero: ");
            Console.WriteLine(
                "1- Ropa y Calzado Para Adultos" +
                "2- Ropa y Calzado Para Bebe " +
                "3- Maquillaje y Accesorios " +
                "4- Medicina");

            Console.WriteLine("Ingrese el Nombre del Producto: ");
            string nomProd = Console.ReadLine();
            Console.WriteLine("Ingrese el Numero de Categoria de Producto: ");
            nuProd = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el precio del Producto: ");
            double precProd = double.Parse(Console.ReadLine());

            switch (nuProd)
            {
                case 1:
                    {
                        Console.WriteLine("Producto: {0}", nomProd);
                        Console.WriteLine("Precio: ${0}", precProd);

                        double impuesto = precProd * 0.05;
                        double premimp = precProd + impuesto;
                        Console.WriteLine("Su impuesto es de: ${0}", impuesto);
                        Console.WriteLine("Su precio total con Impuesto agregado es: ${0}", premimp);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Producto: {0}", nomProd);
                        Console.WriteLine("Precio: ${0}", precProd);

                        double impuesto = precProd * 0.10;
                        double premimp = precProd + impuesto;
                        Console.WriteLine("Su impuesto es de: ${0}", impuesto);
                        Console.WriteLine("Su precio total con Impuesto agregado es: ${0}", premimp);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Producto: {0}", nomProd);
                        Console.WriteLine("Precio: ${0}", precProd);

                        double impuesto = precProd * 0.15;
                        double premimp = precProd + impuesto;
                        Console.WriteLine("Su impuesto es de: ${0}", impuesto);
                        Console.WriteLine("Su precio total con Impuesto agregado es: ${0}", premimp);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Producto: {0}", nomProd);
                        Console.WriteLine("Precio: ${0}", precProd);

                        double impuesto = precProd * 0;
                        double premimp = precProd + impuesto;
                        Console.WriteLine("Su impuesto es de: ${0}", impuesto);
                        Console.WriteLine("Su precio total con Impuesto agregado es: ${0}", premimp);
                        break;
                    }

                default:
                    Console.WriteLine("Sentimos informarle que el numero de Categoria Seleccionada no es valida");
                    break;


            }

            Console.ReadKey();

        }
    }
}

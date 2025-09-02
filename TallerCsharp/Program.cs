using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir un mensaje
            Console.WriteLine("Bienvenido a C#");

            //-- Definir Variables --
            int a, b, producto;

            //--Entrada Datos--
            Console.WriteLine("Ingrese Primer Numero:");
            
            //--Guardar valor de la consola--
            //a= int.Parse(Console.ReadLine());
            a= Convert.ToInt32(Console.ReadLine());
            //a=int.TryParse(Console.ReadLine()); //Boolean True or False

            //--Entrada Datos--
            Console.WriteLine("Ingrese Segundo Numero:");

            //--Guardar valor de la consola--
            //b = int.Parse(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            //b=int.TryParse(Console.ReadLine()); //Boolean True or False

            //-- Proceso --
            producto = a * b;

            //Salida Datos
            Console.WriteLine("El producto es: " + producto);
            Console.WriteLine($"El Producto de {a} * {b} = {producto}");

            //Detener pantalla para mostrar el resultado
            Console.ReadKey();
        }
    }
}

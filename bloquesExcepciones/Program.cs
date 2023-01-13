using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace bloquesExcepciones
{

    class program
    {

        static void Main(string[] args)
        {
            bool comprueba = false;
            do
            {
                try
                {
                    Console.Write("Ingrese un valor:");
                    string linea = Console.ReadLine();
                    var num = int.Parse(linea);
                    var cuadrado = num * num;
                    Console.WriteLine($"El cuadrado de {num} es {cuadrado}");
                    comprueba = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Debe ingresar un entero");
                }
            } while (comprueba == false);

            Console.ReadKey();
        }

    }

}
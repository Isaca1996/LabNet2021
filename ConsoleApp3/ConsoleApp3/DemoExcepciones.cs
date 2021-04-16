using ConsoleApp3.Excepciones;
using System;

namespace ConsoleApp3
{
    class DemoExcepciones
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo Exceptions");
            /*
            try
            {
                EjemploExcepciones.ThrowException();
            }
            catch (Exception)
            {

                Console.WriteLine("Rompio");
            }*/

            EjemploExcepciones.PruebaReturnConFinally();

            try
            {
                EjemploExcepciones.ThrowCustomException();
            }
            catch (CustomException ex)
            {
                Console.WriteLine($"Se capturo la exception custom '{ex.Message}'");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Se capturo{ex.Message}");
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine($"Stack {ex.StackTrace}");
            }

            Console.WriteLine("Termino");
        }
    }
}

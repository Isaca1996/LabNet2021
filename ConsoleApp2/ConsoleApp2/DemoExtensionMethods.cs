using System;
using System.Linq; //LINQ sirve para listas y querys. 

namespace ConsoleApp2
{
    class DemoExtensionMethods
    {
        static void Main(string[] args)
        {

            int numero = 10;
            
            //Acá probamos el sumar una cantidad a un número
            Console.WriteLine(numero.Sumar(100));
            Console.ReadKey();

            //Acá probamos el sumar una cantidad exacta que no se puede cambiar desde acá.
            Console.WriteLine(numero.SumarDiez());
            Console.ReadKey();

            //Acá probamos comparar un mayor o menor que de un número.
            string resultadoOperacion = numero.EsMayorQueCien() ? "Mayor" : "Menor";
            Console.WriteLine($"El numero: {numero}, es {resultadoOperacion} a cien.");
            Console.ReadLine();

            //Acá probamos dos variables y las comparamos sin números estáticos dentro de la clase.
            numero = 120;
            int mayorQue = 50;

            resultadoOperacion = numero.EsMayorQue(mayorQue) ? "Mayor" : "Menor";
            Console.WriteLine($"El numero: {numero}, es {resultadoOperacion} a {mayorQue}.");
            Console.ReadLine();

            //Acá probamos variables de oraciones o palabras y las comparamos o revisamos las mismas. 
            /*string cadenaEjemplo = "Este string contiene ALgo";
            string resultadoCadena = cadenaEjemplo.ContieneAlgo() ? "contiene" : "no contiene";

            Console.WriteLine(string.Format("La cadena '{0}', {1} algo ", cadenaEjemplo, resultadoCadena));
            Console.ReadLine();*/


        }
    }
}

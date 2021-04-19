using TP2_Ejercicio_Exception.Exceptions;
using System;


namespace TP2_Ejercicio_Exception
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Iniciando operaciones.\n");


            //Consigna 1. Ir a EjerciciosTests.cs para ver está con Unit Test
            Ejercicios.Operacion(35, 5);


            //Consigna 2. Ir a EjerciciosTests.cs para ver está con Unit Test
            Ejercicios.Operacion(58, 0);
            Ejercicios.Operacion(null, 3);


            //Consigna 3
            try
            {
                Console.Write("Ingrese el primer numero: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo numero: ");
                int num2 = int.Parse(Console.ReadLine());
                Logic.Comparar(num1, num2);
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"No ha ingresado un número para comparar, su excepción es: {ex.GetType()}.");
            }

            Console.WriteLine(Environment.NewLine);

            //Consigna 4
            try
            {
                Logic.HereIsASpecialException();
            }
            catch (SpecialException ex)
            {
                Console.WriteLine($"La guerra de 100 anios '{ex.Message}'");   
            }


        }
    }
}

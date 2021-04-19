using System;
using System.Collections.Generic;
using System.Text;
using TP2_Ejercicio_Exception.Exceptions;

namespace TP2_Ejercicio_Exception.Exceptions
{
    public class Ejercicios
    {

        public static void Operacion(int? num1, int? num2)
        {
            try
            {
                int division = num1.Value / num2.Value;
                Console.WriteLine("El resultado es: " + division);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("*Homero gritando* NOOOOOOOOO! Solo Chuck Norris divide por cero!");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Seguro ingreso una letra o no ingreso nada!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("StackTrace de la Excepción");
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("\nLa operacion ha sido terminada.");
                Console.WriteLine(Environment.NewLine);
            }
        }


    }
}

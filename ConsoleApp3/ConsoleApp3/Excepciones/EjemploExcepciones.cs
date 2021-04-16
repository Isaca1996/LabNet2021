using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class EjemploExcepciones
    {

        public static void ThrowCustomException()
        {
            throw new CustomException();
        }

        public static void ThrowException()
        {
            try
            {
                DateTime? fechaConValorNULL = null;
                Console.WriteLine("Esto va a romper!");

                string fechaFormateada = fechaConValorNULL.Value.ToString("MM/yy");

            }
            catch (InvalidOperationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Console.WriteLine("Finally paso");
            }
        }

        public static int PruebaReturnConFinally()
        {

            try
            {
                return 1234;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void RealizarOperacion(int? i, int j, bool dividir)
        {
            try
            {
                int multiplicacion = i.Value * j;
                Console.WriteLine("El resultado es " + multiplicacion);
                if (dividir)
                {
                    int division = i.Value / j;
                    Consolte.WriteLine("El resultado es " + division);
                }
            }
            catch (DivideByZeroException ex)
            {

                Console.WriteLine("No se puede dividir por cero");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Devolvio invalid operation exception.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Mensaje de la Excepción");
                Console.WriteLine(ex.Message);
            }

        }

    }
}

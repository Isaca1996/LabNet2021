using System;
using System.Collections.Generic;
using System.Text;

namespace TP2_Ejercicio_Exception.Exceptions
{
    public class Logic
    {

        public static void Comparar(int? num1, int? num2)
        {
                var igual = num1 == num2;
                Console.WriteLine($"¿Son iguales los números ingresados?: {igual}");
        }

        public static void HereIsASpecialException()
        {
            throw new SpecialException();
        }

    }
}

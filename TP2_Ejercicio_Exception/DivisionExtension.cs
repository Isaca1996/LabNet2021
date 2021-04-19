using System;
using System.Collections.Generic;
using System.Text;

namespace TP2_Ejercicio_Exception
{
    public static class DivisionExtension
    {
        public static int division(this int? num1, int? num2)
        {
            int dividir = num1.Value / num2.Value;
            return dividir;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public static class IntegerExtensions
    {
        public static int SumarDiez(this int numero)
        {
            return numero + 10;
        }

        public static int Sumar(this int numero, int otroNumero)
        {
            return numero + otroNumero;
        }

        public static bool EsMayorQueCien(this int numero)
        {
            return numero > 100;
        }

        public static bool EsMayorQue(this int numero, int otroNumero)
        {
            return numero > otroNumero;
        }

    }
}

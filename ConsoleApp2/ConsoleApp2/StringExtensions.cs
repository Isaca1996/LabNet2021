using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public static class StringExtensions
    {
       public static bool ContieneAlgo(this string cadena)
        {
            string cadenaEnMinusculas = cadena.ToLower();
            bool resultado = cadenaEnMinusculas.Contains("algo");
            return resultado;

        }

        /*public static Juan ContieneAlgo(this string cadena)
        {
            return new Juan();

        }*/
    }

    public class Juan
    {

    }

}

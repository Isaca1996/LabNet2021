using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Excepciones
{
    public class CustomException : Exception
    {

        public CustomException() : base("Mensaje de Error de nuestra Custom Exception")
        {

        }

    }
}

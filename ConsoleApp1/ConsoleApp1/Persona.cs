using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Persona : Animal
    {

        public Persona(int cantidadPatas) : base(cantidadPatas)
        {

        }

        public override string Caminar()
        {
            return $"Yo avanzo en {getPatas()} patas";
        }

        public override string Descripcion()
        {
            throw new NotImplementedException();
        }
    }
}

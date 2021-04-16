using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Perro : Animal
    {

        public Perro(int cantidadPatas) : base(cantidadPatas)
        {

        }

        public override string Caminar()
        {
            return string.Format("Yo avanzo {0} patas", getPatas());
        }

        public override string Descripcion()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public abstract class Animal
    {
        private int cantidadPatas;

        public Animal(int cantidadPatas)
        {
            this.cantidadPatas = cantidadPatas;
        }

        public int getPatas()
        {
            return cantidadPatas;
        }

        public abstract string Caminar();

        public abstract string Descripcion();



    }
}

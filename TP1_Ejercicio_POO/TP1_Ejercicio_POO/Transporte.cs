using System;
using System.Collections.Generic;
using System.Text;

namespace TP1_Ejercicio_POO
{
    public abstract class Transporte
    {
        private int pasajeros;

        public Transporte (int pasajeros)
        {
            this.pasajeros = pasajeros; 
        }

        public int GetPasajeros()
        {
            return pasajeros;
        }

        public abstract string Avanzar();

        public abstract string Detenerse();

        public abstract string MostrarPasajeros();


    }
}

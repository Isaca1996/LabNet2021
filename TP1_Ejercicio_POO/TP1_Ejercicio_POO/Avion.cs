using System;
using System.Collections.Generic;
using System.Text;

namespace TP1_Ejercicio_POO
{
    public class Avion : Transporte
    {
        private int idAvion;

        public Avion (int idAvion, int pasajeros) : base(pasajeros)
        {
            this.idAvion = idAvion;
        }

        public int GetIdAvion()
        {
            return idAvion;
        }

        public override string MostrarPasajeros()
        {
            return $"Avion {GetIdAvion()}: {GetPasajeros()} pasajeros.";
        }

        public override string Avanzar()
        {
            return $"El avión {GetIdAvion()} despega con {GetPasajeros()} pasajeros.";
        }

        public override string Detenerse()
        {
            return $"El avión {GetIdAvion()} se detiene y los {GetPasajeros()} pasajeros bajan de forma ordenada.";
        }

    }
}

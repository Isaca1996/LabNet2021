using System;
using System.Collections.Generic;
using System.Text;

namespace TP1_Ejercicio_POO
{
    public class Automovil : Transporte
    {
        private int patente;

        public Automovil(int patente, int pasajeros) : base(pasajeros)
        {
            this.patente = patente;
        }

        public int GetPatente()
        {
            return patente;
        }

        public override string MostrarPasajeros()
        {
            return $"Automovil {GetPatente()}: {GetPasajeros()} pasajeros.";
        }

        public override string Avanzar()
        {
            return $"El automovil con patente {GetPatente()} avanza con {GetPasajeros()} pasajeros.";
        }

        public override string Detenerse()
        {
            return $"El automovil se detiene a un lado de la calle y los {GetPasajeros()} pasajeros se bajan.";
        }
    }
}

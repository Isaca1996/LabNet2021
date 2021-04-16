using System;
using System.Collections.Generic;

namespace TP1_Ejercicio_POO
{
    class DemoEjercicio
    {
        static void Main(string[] args)
        {
            //Resolución de acuerdo a la consigna.

            List<Transporte> transportes1 = new List<Transporte>
            {
                new Automovil(1, 2),
                new Automovil(2, 4),
                new Automovil(3, 5),
                new Automovil(4, 3),
                new Automovil(5, 8),
                new Avion(1, 93),
                new Avion(2, 30),
                new Avion(3, 45),
                new Avion(4, 150),
                new Avion(5, 78)
            };

            foreach (var item in transportes1)
            {
                Console.WriteLine(item.MostrarPasajeros());
            }

            Console.ReadLine();

            //Agregado.

            List<Transporte> transportes2 = new List<Transporte>
            {
                new Automovil(6321458, 2),
                new Automovil(7842251, 4),
                new Automovil(8951437, 5),
                new Automovil(9621852, 3),
                new Automovil(1094785, 8),
                new Avion(110, 93),
                new Avion(258, 30),
                new Avion(343, 45),
                new Avion(446, 150),
                new Avion(579, 78)
            };

            foreach (var item in transportes2)
            {
                Console.WriteLine(item.Avanzar());
            }

            Console.ReadLine();

            foreach (var item in transportes2)
            {
                Console.WriteLine(item.Detenerse());
            }

            Console.ReadLine();
            

        }
    }
}

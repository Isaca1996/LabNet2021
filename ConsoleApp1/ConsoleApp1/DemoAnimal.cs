using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class DemoAnimal
    {
        static void Main(string[] args)
        {
            List<Animal> animales = new List<Animal>
            {
                new Persona(2),
                new Perro(4)
            };

            foreach (var item in animales)
            {
                Console.WriteLine(item.Caminar());
            }

            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp5
{
    class Program
    {
        static string[] ANIMAL_TYPES = new string[] { "Hippopotamus", "Red Panda", "Penguin", "Flamingo" };

        private static double randomGenerator(Random r, double min, double max)
        {
            return (r.NextDouble() * (max - min)) + min;
        }

        static void Main(string[] args)
        {
            var rnd = new Random();
            var animalList = new List<Animal>();
            do
            {
                Console.WriteLine();
                Console.WriteLine("Enter a name for your favourite animal:");
                string animalName = Console.ReadLine();
                var animal = new Animal()
                {
                    Name = animalName,
                    Age = randomGenerator(rnd, 0.0d, 120d),
                    Type = ANIMAL_TYPES[Convert.ToInt32(Math.Floor(randomGenerator(rnd, 0, 4)))],
                    WeightInLbs = randomGenerator(rnd, 300d, 4800.5d)
                };
                //add method to add animals
                animalList.Add(animal);
                Console.Write("Have you had enough animal action? (Y if so)\t");
            } while (Console.ReadKey().Key != ConsoleKey.Y);
            Console.WriteLine();
            animalList.ForEach(Console.WriteLine);
            var zoo = animalList.ToDictionary(a => a.Type, a => a);

            for (int x = 0; x < zoo.Count; x++)
            {
                Console.WriteLine("zero index: {0} and one index: {1} ", zoo.Keys.ElementAt(x));
                                    
            }




        }
    }
    
}

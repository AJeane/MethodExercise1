using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            string band = Console.ReadLine();

            //string interpolation.

            Console.WriteLine(); _ = $"Hello {name}. I heard about you, is your favorite animal still the {color} {animal}? Actually nevermind, though you said you like {band} right?";








        }
    }
}

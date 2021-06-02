using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var favNumber = random.Next(1, 1000);

            var userInput = int.Parse(Console.ReadLine());

            if (userInput == favNumber)
            {
                Console.WriteLine("You guessed the right number!");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too high!");
            }
            else if (userInput < favNumber)
            {
                Console.WriteLine("Too low!");
            }
            else
            {
                Console.WriteLine("Nevermind.");
            }
        }
    }
}

using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "cameron";
            string guess = "";
            while (guess != secretWord)
            {
                Console.Write("Enter your guess : ");
                guess = Console.ReadLine();
            }
            Console.Write("You win!!!!");
        }
    }
}

using System;

namespace Guessing{
class GuessTheNumber
{
    static void Main()
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 101); // Generate a number between 1 and 100
        int attempts = 0;
        bool guessedCorrectly = false;

        Console.WriteLine("Welcome to the Guess the Number Game!");
        Console.WriteLine("I'm thinking of a number between 1 and 100. Can you guess it?");

        while (!guessedCorrectly)
        {
            Console.Write("Enter your guess: ");
            string userInput = Console.ReadLine();
            attempts++;

            if (int.TryParse(userInput, out int userGuess))
            {
                if (userGuess < 1 || userGuess > 100)
                {
                    Console.WriteLine("Please enter a number between 1 and 100.");
                }
                else if (userGuess < secretNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (userGuess > secretNumber)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed the number in {attempts} attempts.");
                    guessedCorrectly = true;
                }
            }
            else
            {
                Console.WriteLine("That's not a valid number. Please try again.");
            }
        }

        Console.WriteLine("Thanks for playing!");
    }
}
}

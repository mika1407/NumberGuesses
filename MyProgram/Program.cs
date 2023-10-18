using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            String response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = rnd.Next(min, max+1);

                while (guess != number)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Guess a number between " + min + "-" + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);
                    Console.ResetColor();

                    if (guess > number)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(guess + " is too high!");
                        Console.ResetColor();
                    }
                    else if (guess < number)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(guess + " is too low!");
                        Console.ResetColor();
                    }
                    guesses++;
                }
                Console.WriteLine("Right number is: " + number);
                Console.WriteLine("YOU WIN!");
                Console.WriteLine("Guesses: " + guesses);

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Would you like to play again (Y/N): ");
                response = Console.ReadLine() ?? string.Empty;
                response = response.ToUpper();
                Console.ResetColor();

                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Thank you for playing! ");
            Console.ResetColor();

            Console.ReadKey();
        }
    }
}
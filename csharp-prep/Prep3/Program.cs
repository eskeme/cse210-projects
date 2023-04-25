using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;
        while (playAgain)
        {
            Random random = new Random();
            int magicNumber = random.Next(1, 101);
            int guessCount = 0;

            Console.WriteLine("I'm thinking of a number between 1 and 100. Can you guess it?");

            int guess = 0;
            while (guess != magicNumber)
            {
                Console.Write("Enter your guess: ");
                guess = int.Parse(Console.ReadLine());

                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Too low! Guess higher next time.");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Too high! Guess lower next time.");
                }
                else
                {
                    Console.WriteLine("Congratulations, you guessed it!");
                    Console.WriteLine("You made {0} guesses.", guessCount);
                }
            }

            Console.Write("Do you want to play again? (yes/no) ");
            string playAgainAnswer = Console.ReadLine();
            playAgain = playAgainAnswer.ToLower() == "yes";
        }
    }
}

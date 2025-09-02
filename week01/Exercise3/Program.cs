using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        int guess = 0;

        while (guess != number)
        {
            Console.Write("What is your guess? ");
            string attempt = Console.ReadLine();
            guess = int.Parse(attempt);
            if (guess == number)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }
        }
        
    }
}
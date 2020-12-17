using System;

namespace NumGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            int randomNumber = rand.Next(0, 101);
            int lives = 5;
            int answer = 0;
            while(lives > 0)
            {
                Console.Write("Guess a number:\n\t");
                answer = Int32.Parse(Console.ReadLine());
                if (answer == randomNumber) break;
                if(answer > randomNumber)
                {
                    Console.WriteLine("too high");
                }
                else
                {
                    Console.WriteLine("too low");
                }
                lives--;
                Console.WriteLine("Wrong, try again\n----\n");
            }
            Console.WriteLine($"\n\n\tGuess number was {randomNumber}\n\n\n");
        }
    }
}

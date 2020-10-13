using System;

namespace GuessNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,scoreA,scoreB;
            Random rand = new Random();
            int randomNumber = rand.Next(1,11);
            
            Console.WriteLine("Let's Play the game of guessing the number between 1 and 10!");
            Console.WriteLine("\nPlayer A: Please enter the number:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Player B: Plaese enter the number:");
            b = Convert.ToInt32(Console.ReadLine());

            scoreA = Math.Abs(randomNumber - a);
            scoreB = Math.Abs(randomNumber - b);

            if(scoreA<scoreB)
            {
                Console.WriteLine(" Player A won!!");
            }
            else if(scoreB<scoreA)
            {
                Console.WriteLine("Player B won!!");
            }
            else
            {
                Console.WriteLine("It's a DRAW!!");
            }
            Console.WriteLine("Number was "+ randomNumber);

            Console.ReadKey();


        }
    }
}

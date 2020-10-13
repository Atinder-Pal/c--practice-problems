using System;

namespace GuessEvenOddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an Integer:");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num % 2 ==0)
            {
                Console.WriteLine("The number entered is EVEN");
            }
            else
            {
                Console.WriteLine("The number entered is ODD");
            }
            Console.ReadKey();
        }
    }
}

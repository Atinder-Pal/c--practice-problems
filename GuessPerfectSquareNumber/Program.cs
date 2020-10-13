using System;

namespace GuessPerfectSquareNumber
{
    class Program
    {
         public static ConsoleKey consoleKey;
         public static void Main(string[] args)
        {
           
            double num,sqrtNum;
            Console.WriteLine("Please enter any number:");
            num = Convert.ToDouble(Console.ReadLine());

            sqrtNum = Math.Sqrt(num);

            //Citation
            //https://stackoverflow.com/questions/31938532/best-way-for-check-if-a-variable-is-a-whole-number
            bool boo = (int)sqrtNum == sqrtNum;
            //End Citation
                        
            if (boo)
            {
                Console.WriteLine("Entered number is the perfect square of whole number "+ sqrtNum);
            }
            else
            {
                Console.WriteLine("Entered number is not the perfect square of a whole number");
            }
        
            while(consoleKey != ConsoleKey.Enter)
            {
                Console.WriteLine("\n Press Enter key to exit");
                consoleKey = Console.ReadKey().Key;
            }
            

        }
    }
}

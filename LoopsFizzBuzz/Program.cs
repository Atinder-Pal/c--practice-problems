using System;

namespace LoopsFizzBuzz
{
    

    class Program
    {
        public static ConsoleKey consoleKey;
        static void Main(string[] args)
        {
            for (int i=1;i<101;i++)
            {
                if (i % 3==0 )
                {
                    if(i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                    else
                    Console.WriteLine("Fizz");
                }
                
                else if (i % 5 ==0)
                {
                Console.WriteLine("Buzz");
                }

                else
                Console.WriteLine(i);

            }
            while (consoleKey != ConsoleKey.Enter)
            {
                Console.WriteLine("Press Enter key to exit");
                consoleKey = Console.ReadKey().Key;
            }
        }
    }
}

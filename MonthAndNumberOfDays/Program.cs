using System;

namespace MonthAndNumberOfDays
{
    class Program
    {
        public static ConsoleKey consoleKey;
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 3 letter code for the month:");
            string month = Console.ReadLine().ToLower();

            switch (month)
            {
                case "jan": Console.WriteLine("This is January and it has 31 days");
                break;

                case "feb": Console.WriteLine("Please enter the year  to determine number of days:");
                int year = Convert.ToInt32(Console.ReadLine());
                if (year % 4 ==0)
                {
                    Console.WriteLine(" This is February and it has 29 days");
                }
                else
                    Console.WriteLine(" This is February and it has 28 days");
                break;

                case "mar": Console.WriteLine("This is March and it has 31 days");
                break;

                case "apr": Console.WriteLine("This is April and it has 30 days");
                break;

                case "may": Console.WriteLine("This is May and it has 31 days");
                break;

                case "jun": Console.WriteLine("This is June and it has 30 days");
                break;

                case "jul": Console.WriteLine("This is July and it has 31 days");
                break;

                case "aug": Console.WriteLine("This is August and it has 31 days");
                break;

                case "sep": Console.WriteLine("This is September and it has 30 days");
                break;

                case "oct": Console.WriteLine("This is October and it has 31 days");
                break;

                case "nov": Console.WriteLine("This is November and it has 30 days");
                break;

                case "dec": Console.WriteLine("This is December and it has 31 days");
                break;

                default: Console.WriteLine("You did not enter correct code");
                break;
            }
            while(consoleKey!= ConsoleKey.Enter)
            {
                Console.WriteLine("\n Press Enter key to exit");
                consoleKey = Console.ReadKey().Key;
            }
        }
    }
}

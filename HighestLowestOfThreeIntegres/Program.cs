using System;

namespace HighestLowestOfThreeIntegres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter three integers:");
            int a = Int32.Parse(Console.ReadLine()) ;
            int b = Int32.Parse(Console.ReadLine());
            int c = Int32.Parse(Console.ReadLine());
            
            int highest = Math.Max((Math.Max(a,b)),c);
            Console.WriteLine($"Highest is {highest}");

            int lowest = Math.Min((Math.Min(a,b)),c);
            Console.WriteLine($"Lowest is {lowest}");
            
            Console.ReadKey();

        }
    }
}

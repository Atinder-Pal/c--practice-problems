using System;

namespace StringToUppercase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string");
            String st = Console.ReadLine();
            Console.WriteLine(st.ToUpper());
            Console.ReadKey();
        }
    }
}

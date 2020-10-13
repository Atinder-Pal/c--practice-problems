using System;

namespace PaintRequiredForPosts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of fence posts you want to paint");
            int posts = Int32.Parse(Console.ReadLine());
            double bucketsForOnePost = 0.25;
            Console.WriteLine("Number of buckets of paint needed is " + Math.Ceiling(posts*bucketsForOnePost));

            Console.ReadKey();
        }
    }
}

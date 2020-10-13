using System;

namespace WhileLoopGetIntOneToTen
{
    class Program
    {
        
        static void Main(string[] args)
        {                    
                      
            Console.WriteLine("Please enter an integer in the range 1 to 10:");
            int num = Convert.ToInt32(Console.ReadLine());
            
            
            while (num <1 || num >10)
            {
                Console.WriteLine("Please enter an integer in the range 1 to 10.");
                num = Convert.ToInt32(Console.ReadLine());
            }
            
           
        }
    }
}

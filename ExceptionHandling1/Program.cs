using System;

namespace ExceptionHandling1
{
    class Program
    {
        
        static void Main(string[] args)
        {

            try
            {
            int num=0;
            bool isNumber = false;
                while(!isNumber)
                {
                Console.WriteLine("Please enter an integer in the range 1 to 10:");
                var numberAsString = Console.ReadLine();
                isNumber= int.TryParse(numberAsString,out num);
                }   

                if(num <1 || num >10)
                {
                throw new Exception("Number should be in range 1 to 10");
                
                }
                
            }          
                        
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}

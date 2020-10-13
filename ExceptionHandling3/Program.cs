using System;

namespace ExceptionHandling3
{
    class Program
    {
        
        public static ConsoleKey consoleKey;
        static void Main(string[] args)
        {
            bool duplicacyCheck = true, whitespaceCheck=true;
            
            while(duplicacyCheck)
            {
                     
            Console.WriteLine("Please enter 3 divisors");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please 3 associated words with the entered divisors respectively");
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            string str3 = Console.ReadLine();
            whitespaceCheck = ((string.IsNullOrWhiteSpace(str1))||(string.IsNullOrWhiteSpace(str2))||(string.IsNullOrWhiteSpace(str3)));
            duplicacyCheck = ((num1==num2||num2== num3||num1==num3)||(str1==str2||str2==str3||str1==str3));
            try
            {
            if(whitespaceCheck)  
            {
                throw new Exception("Associated words can not be empty or whitespace");
            }  
            //checking for duplicacy
            if(duplicacyCheck)
            {
                throw new Exception("Duplicate values found!, Can not enter duplicate divisors or associated words");
            }

            //checking if aany Divisor is less than 2
            if(num1<2||num2<2||num3<2)
            {
                throw new Exception("Divisor should not be less than 2");
            }

            Console.WriteLine("Please enter the start point and end point for Counting respectively");
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            
            if(end<start)
            {
                throw new Exception("End point cannot be less than start point");
            }
            
            if(start<= 0||end <= 0)
            {
                throw new Exception("Start point or End point can not be 0");
            }
            if((end - start)>100)
            {
                throw new Exception("Span between start and end point can not be greater than 100");
            }

            for (int i=start;i<end+1;i++)
            {
                if (i % num1==0 )
                {
                    Console.WriteLine(str1);
                }
                
                else if (i % num2 ==0)
                {
                    Console.WriteLine(str2);
                }

                else if (i % num3 ==0)
                {
                    Console.WriteLine(str3);   
                }

                else
                Console.WriteLine(i);

            }
            
            }
            
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
            }           
            
            while (consoleKey != ConsoleKey.Enter)
            {
                Console.WriteLine("Press Enter key to exit");
                consoleKey = Console.ReadKey().Key;
            }
        }
    }
}

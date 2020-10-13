using System;

namespace ExceptionHandling2
{
    class Program
    {
        
        public static ConsoleKey ck;
        static void Main(string[] args)
        {
           string ops = "+-*/%";
            Console.WriteLine("Please enter an operator from the following:\n +, -, *, /, %");
            string op = Console.ReadLine();
            while(!ops.Contains(op))
            {
                Console.WriteLine("Please enter an operator from the following:\n +, -, *, /, %");
                op = Console.ReadLine();
            }
            
            Console.WriteLine("Please enter two integers to perform the above function");
            int op1 = Int32.Parse(Console.ReadLine());
            int op2 = Int32.Parse(Console.ReadLine());

            switch (op)
            {
                case "+": Console.WriteLine($"{op1} + {op2} = "+ (op1 + op2));
                break;
                
                case "-": Console.WriteLine($"{op1} - {op2} = "+ (op1 - op2));
                break;
                
                case "*": Console.WriteLine($"{op1} * {op2} = "+ (op1 * op2));
                break;
                
                case "/" :
                
                    try
                    {
                        if(op2 ==0)
                        {
                            throw new DivideByZeroException("Please enter any integer other than zero for divisor ");
                        }
                        Console.WriteLine($"{op1} / {op2} = "+ Math.Round((double)op1 / op2, 2));
                    }
                     catch(DivideByZeroException ex)
                    {
                    Console.WriteLine(ex.Message);
                    }
                break;
                
                case "%" :
                    try
                    {
                        if(op2 ==0)
                        {
                            throw new DivideByZeroException("Please enter any integer other than zero for divisor" );
                        }
                        Console.WriteLine($"{op1} % {op2} = "+ (op1 % op2));
                    }
                     catch(DivideByZeroException ex)
                    {
                    Console.WriteLine(ex.Message);
                    }
                break;                       
               
            }
            while(ck!= ConsoleKey.Enter)
                {
                    Console.WriteLine("\n Press Enter key to exit");
                    ck = Console.ReadKey().Key;
                }
            
        }
    }
}

using System;
using System.Linq;

namespace OperatorTwoOperands
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
                if (op2==0)
                {
                    Console.WriteLine($"{op1} / {op2} = Cannot divide by 0");
                }
                else
                {
                    Console.WriteLine($"{op1} / {op2} = "+ Math.Round(((double)op1 /(double) op2),2));
                }
                break;
                
                case "%" :
                if (op2==0)
                {
                    Console.WriteLine($"{op1} % {op2} = Cannot divide by 0");
                }
                else
                {
                    Console.WriteLine($"{op1} % {op2} = "+ (op1 % op2));
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

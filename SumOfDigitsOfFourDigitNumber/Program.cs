using System;

namespace SumOfDigitsOfFourDigitNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int fourDigitNumber, sum=0,digit;
            Console.WriteLine("Please enter a four digit number");
            fourDigitNumber= Int32.Parse(Console.ReadLine());
            int value= fourDigitNumber;

            //Citation:
            //https://stackoverflow.com/questions/9302681/c-how-to-break-apart-a-multi-digit-number-into-separate-variables
            //I figured the logic but was confused as to how to implement so copied while loop
            while(value>0)
            {
                digit = value % 10;
                sum = sum + digit;
                value = value/10;
            }
            //End citation
            
            Console.WriteLine("Sum of the digits is " + sum);
            Console.ReadLine();
        }
    }
}

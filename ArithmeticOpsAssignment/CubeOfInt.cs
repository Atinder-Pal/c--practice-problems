using System;

namespace ArithmeticOpsAssignment
{
    class cubeOfInt
    {
        static void Main(string[] args)
        {
            //Declaring an int type variable
            int a;

            //Asking the user to input an interger to check its cube
            Console.WriteLine("Please Enter the integer ");

            // Citation:
            // https://www.javatpoint.com/sum-of-digits-program-in-csharp
            // Copied the code to parse through user input and convert it into 'int' 
            //Reading user's output and converting it into 'int' type and storing 
            // its value in a variable
            a= int.Parse(Console.ReadLine());
            // End citation

            //Printing the cube of the number on console
            Console.WriteLine( "Cube of "+ a +" is "+ Math.Pow(a,3));

            //Letting the output stay on console 
            Console.ReadLine();
        }
    }
}

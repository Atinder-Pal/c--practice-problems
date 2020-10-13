using System;

namespace PythagorasTheorem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's find length of the Hypotenuse of a Right triangle\n Please enter length of base and perpendicular ");
            //Citation
            //https://stackoverflow.com/questions/13813166/read-user-input-of-double-type
            //Just copied code to change string representation to Double
            double b = Convert.ToDouble(Console.ReadLine());
            double p = Convert.ToDouble(Console.ReadLine());

            double h = Math.Round(Math.Sqrt((Math.Pow(b,2)+ Math.Pow(p,2))),2);
            Console.WriteLine($"Length of Hypotenuse is {h} ");
            

        }
    }
}

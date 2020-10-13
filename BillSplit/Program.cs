using System;

namespace BillSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalDollarValue;
        int numberOfDiners;
        Double equallySplitBill;
        
        Console.WriteLine("Please enter the total dollar value of the bill");
        totalDollarValue= Int32.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the number of diners");
        numberOfDiners= Int32.Parse(Console.ReadLine());
       
        equallySplitBill= totalDollarValue/numberOfDiners;
        
        Console.WriteLine("Amount of bill split equally that each diner should pay is $" + equallySplitBill);
        Console.ReadLine();
        }
    }
}

using System;

namespace BirthYearFromAge
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = DateTime.Now;                  
            int currentYear= d.Year;
            int age, yearOfBirth;
            
            Console.WriteLine("Please enter your age");
            age= Int32.Parse(Console.ReadLine());
            
            yearOfBirth= currentYear-age;

            Console.WriteLine("Your year of birth is "+ yearOfBirth);
            Console.ReadLine();

        }
    }
}

using System;

namespace RandomPasswordFiveCharLong
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            string pwd ="";
            
            for (int i=0;i<5;i++)
            {
                int randomNumber = rand.Next(65,123);
                
                //This is to avoid Ascii range 91 to 96 for special characters
                if(randomNumber>90 && randomNumber<97)
                {randomNumber+=7;}
                
                //Citation
                //https://www.techiedelight.com/convert-int-to-char-csharp/
                //Copied code to cast Integer to string
                char randomChar = Convert.ToChar(randomNumber);
                //End Citation

                //Citation
                //https://stackoverflow.com/questions/36721485/add-char-to-empty-string-c-sharp
                // checked code to append char to a string
                pwd += randomChar;
                //End citation
            }
                Console.WriteLine("Random password is "+ pwd);
                               
                Console.ReadKey();
           
        }
    }
}

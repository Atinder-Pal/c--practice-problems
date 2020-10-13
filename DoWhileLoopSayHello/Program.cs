using System;

namespace DoWhileLoopSayHello
{
    class Program
    {
        static void Main(string[] args)
        {
            string st = "";
            do
            {
                Console.WriteLine("Hello");
                st = Console.ReadLine();              
                //Console.WriteLine("Type 'Stop' to exit");
            }while (st.ToLower() != "stop");
        }
    }
}

using System;

namespace LoopsClassMarks
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer="";
            do
            {
                int marks=0, highestMarks=0 , lowestMarks=100 , sum =0, counter=0;
                for (int i=0;i<20;i++)
                {
                    Console.WriteLine("Please enter marks:");
                    marks = Convert.ToInt32(Console.ReadLine());
                    
                    if(marks<-1 || marks>100 )
                    {
                        i--;
                        continue;
                    }
                    else if(marks == -1 && i !=0)
                    {
                        break;
                    }
                    else if(marks == -1 && i ==0)
                    {
                        i--;
                        continue;
                    }

                    highestMarks = marks>highestMarks ? marks : highestMarks;
                    lowestMarks = marks <lowestMarks ? marks : lowestMarks;
                    sum += marks;
                    counter+=1;
                    
                }
                                
                Console.WriteLine("Average Marks = "+ (Math.Round((double) sum/counter,2)));
                Console.WriteLine("Highest Marks= "+ highestMarks);
                Console.WriteLine("Lowest Marks = "+ lowestMarks);

                Console.WriteLine("Do you want to start again? Press y for yes and any other key to exit");
                answer = Console.ReadLine().ToLower();

            }while(answer == "y");
                

        }
    }
}

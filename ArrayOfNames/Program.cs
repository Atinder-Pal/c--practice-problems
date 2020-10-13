using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ArrayOfNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] names= {};
            bool toContinue=false;
            char operation = 'i';
            
            
            do{
            try{
            
            Console.WriteLine("\n What would you like to do with the List \n Type 'I' to insert, 'U' to update, 'D' to delete, 'O' to output the contents of the list");
            operation = char.Parse(Console.ReadLine().ToLower());
            
            //Citation
            //https://stackoverflow.com/questions/13257458/check-if-a-value-is-in-an-array-c
            //Used the website to see how to check if a value is contained in the array without using the loop 
            // isValid = validOperations.Contains(operation);
            // toContinue= !isValid;
            
            //End citation
            //}
            
            

            
            switch (operation)
            {
                case ('i'):
                {
                    if(names.Length ==10)
                    {
                        throw new Exception("List can only have 10 names. Please delete something to add a new name");
                    }
                    Console.WriteLine("Please enter the name you want to insert in the list:");
                    string temp = Console.ReadLine().ToUpper().Trim();

                    if(names.Contains(temp))
                    {
                        throw new Exception("This name already exists in list");
                    }
                    if(temp.Length <2) // Regex.IsMatch(temp, @"\s"))
                    {
                        throw new Exception("Name cannot be less than 2 letters");
                    }
                    if(String.IsNullOrWhiteSpace(temp))
                    {
                        throw new Exception("Name cannot be empty");
                    }
                    if(Regex.IsMatch(temp, @"\s"))
                    {
                        throw new Exception("Name cannot be more than a word and no space allowed");   
                    }
                    
                    if(names.Length ==10)
                    {
                        throw new Exception("NList can only have 10 names. Please delete something to add a new name");
                    }
                    //names[Array.IndexOf(names,null)]= temp;
                    names = names.Concat(new string[] { temp}).ToArray();
                                                        
                }
                break;

                case ('u'):
                {
                    
                    if(names[0] == null)
                    {
                        throw new Exception("list is empty!");
                    }                    
                    
                    Console.WriteLine("Type 'n' to update by name and 'i' to update by index ");
                    char updateChoice = char.Parse(Console.ReadLine());
                    switch (updateChoice)
                    {
                        case ('n'):
                        {
                            Console.WriteLine("Please enter the name you want to update and new name you want it updated to");
                            string oldName = Console.ReadLine().ToUpper();
                            string newName = Console.ReadLine().ToUpper().Trim();
                            if(names.Contains(newName))
                            {
                                throw new Exception("This name already exists in list");
                            }
                            if(newName.Length <2) // Regex.IsMatch(temp, @"\s"))
                            {
                                throw new Exception("Name cannot be less than 2 letters");
                            }
                            if(String.IsNullOrWhiteSpace(newName))
                            {
                                throw new Exception("Name cannot be empty");
                            }
                            if(Regex.IsMatch(newName, @"\s"))
                            {
                                throw new Exception("Name cannot be more than a word and no space allowed");   
                            }
                            names[Array.IndexOf(names, oldName)] = newName;
                                
                        }
                        break;

                        case ('i'):
                        {
                            Console.WriteLine("Please enter the index you want to update (starting from 1) and new name you want it updated to");
                            int inputIndex = int.Parse(Console.ReadLine())-1;
                            string newName = Console.ReadLine().ToUpper().Trim();
                            if(names.Contains(newName))
                            {
                                throw new Exception("This name already exists in list");
                            }
                            if(newName.Length <2) // Regex.IsMatch(temp, @"\s"))
                            {
                                throw new Exception("Name cannot be less than 2 letters");
                            }
                            if(String.IsNullOrWhiteSpace(newName))
                            {
                                throw new Exception("Name cannot be empty");
                            }
                            if(Regex.IsMatch(newName, @"\s"))
                            {
                                throw new Exception("Name cannot be more than a word and no space allowed");   
                            }
                            names[inputIndex] = newName;
                               
                        }
                        break;
                        default:
                        {
                            Console.WriteLine("Invalid character entered");
                        }
                        break;
                    }
                }
                break;

                case ('d'):
                {
                    if(names[0] == null)
                    {
                        throw new Exception("list is empty!");
                    } 
                    
                    Console.WriteLine("Type 'n' to delete by name and 'i' to delete by index ");
                    char deleteChoice = char.Parse(Console.ReadLine());
                    switch (deleteChoice)
                    {
                        case ('n'):
                        {
                            Console.WriteLine("Please enter the name you want to delete");
                            string deleteName = Console.ReadLine().ToUpper();
                            
                            if(names.Contains(deleteName))
                                {
                                    //Citation
                                    //https://stackoverflow.com/questions/496896/how-to-delete-an-element-from-an-array-in-c-sharp/497005
                                    names = names.Where(val => val != deleteName).ToArray();
                                    //End citation
                                }                           
                               
                        }
                        break;

                        case ('i'):
                        {
                            Console.WriteLine("Please enter the index you want to delete (starting from 1) ");
                            int inputIndex = int.Parse(Console.ReadLine())-1;
                            
                            names = names.Where((val, idx) => idx != inputIndex).ToArray();
                               
                        }
                        break;
                        default:
                        {
                            Console.WriteLine("Invalid character entered");
                        }
                        break;
                    }
                }
                break;

                case ('o'):
                {
                    int i=1;
                    foreach(string s in names)
                                {                                        
                                Console.WriteLine(i+"."+ s);
                                i++;
                                }
                }
                break;
                default:
                {
                    Console.WriteLine("Invalid operation");
                    
                }
                break;
            }
            
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Do you want to continue? Press y for yes and any key to quit");
                string isContinue= Console.ReadLine().ToLower();
                toContinue = isContinue == "y";
            }
            } while (toContinue);
            Console.ReadKey();
        }
    }
}

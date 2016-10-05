using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Names = new List<string>();

            Names.Add("Linus Torvalds");
            Names.Add("Donald Knuth");
            Names.Add("Grace Hopper");
            Names.Add("Bill Gates");
            Names.Add("Leon Kennedy");

            string doAnother = string.Empty;
            do
            {
                DisplayForLoop(Names); //made by right clicking and making a new method, now method is at bottom in private static for 
                Console.WriteLine("Do you want to Add(A), Remove(R) or Search(S)?");

                string userInput = Console.ReadLine();
                switch (userInput.ToUpper())
                {
                    case "A":
                        Console.WriteLine("Please enter a name: ");
                        var name = Console.ReadLine();
                        Names.Add(name);
                        break;
                    case "R":
                        Console.WriteLine("Please enter a name or position to remove: ");
                        var removeName = Console.ReadLine();
                        int index;
                        if (int.TryParse(removeName, out index)) //if it returns and it is true then we'll use RemoveAt
                        {
                            Names.RemoveAt(index - 1);
                        }
                        else
                        {
                            Names.Remove(removeName);
                        }
                        break;
                    case "S":
                        Console.WriteLine("Enter name to search: ");
                        var searchName = Console.ReadLine();
                        Console.WriteLine("The index of the name is: " + Names.IndexOf(searchName)); // used to search name in our program
                        break;
                    default:
                        Console.WriteLine("Please enter A, R, S.");
                        break;
                }
                Console.WriteLine("Do another (y/n)");
                doAnother = Console.ReadLine();
            } while (doAnother == "y");




            /*
            foreach (string item in Names) //Brian uses item keyword because it's easy 
            {
                Console.WriteLine(item);
            }
            
            Names.TrimExcess(); //trims all the excess from the lists created and gives it's true count. 

            Console.WriteLine("Capacity: " + Names.Capacity);
            Console.WriteLine("Count: " + Names.Count); //length and count are the same thing. 

            Names.Remove("Bill Gates");
            Names.RemoveAt(3);
            foreach (string item in Names)
            {
                Console.WriteLine(item);
            }
            */

                        Console.ReadLine();
        }

        private static void DisplayForLoop(List<string> Names)
        {
            for (int i = 0; i < Names.Count(); i++)
            {
                Console.WriteLine(Names[i]);
            }
        }
    }
}

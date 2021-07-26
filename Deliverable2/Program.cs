using System;
using System.Collections.Generic;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            List<string> inputList = new List<string>();

            while (true)
            {
                Console.Write("What would you like to say? ");
                string userInput = Console.ReadLine();
                string lCaseInput = userInput.ToLower();

                if (inputList.Contains(lCaseInput))
                {
                    Console.WriteLine("I'm sorry, but you have already said that.\n");
                }

                else
                {
                    if (lCaseInput == "hello")
                    {
                        Console.WriteLine("Hi good to see you");
                    }

                    else if (lCaseInput == "sup")
                    {
                        Console.WriteLine("I am good");
                    }

                    else if (lCaseInput == "hello there")
                    {
                        Console.WriteLine("General Kenobi");
                    }

                    else if (lCaseInput == "bye")
                    {
                        Console.WriteLine("Good bye!");
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Please enter a valid input.");
                    }

                    inputList.Add(lCaseInput);
                }

                Console.WriteLine("\nSay something else.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Magic8Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor oldColor = Console.ForegroundColor;

            WhatProgramIsThis();
            Random randomObject = new Random();
            while (true)
            {
                string questionString = GetQuestion();
                int secsToSleep = randomObject.Next(3) + 1;
                Console.WriteLine("Gimme a second to think...");
                Thread.Sleep(secsToSleep * 1000);
                if (questionString.Length == 0)
                {
                    Console.WriteLine("You need to ask a question");
                    continue;
                }

                if (questionString.ToLower() == "quit")
                {
                    break;
                }



                int randomNumber = randomObject.Next(4);
                int randomColor = randomObject.Next(15);
                Console.ForegroundColor = (ConsoleColor)randomColor;

                switch (randomNumber) {
                    case 0:
                        {
                            Console.WriteLine("Yes!");
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("No!");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Hell Yes!");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Hell No!");
                            break;
                        }

                }
            }

            Console.ForegroundColor = oldColor;
        }

        static void WhatProgramIsThis()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Magic 8 Ball By Kevin");
        }

        static string GetQuestion() {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Ask a question?: ");

            string questionString = Console.ReadLine();
            return questionString;
        }
    }
}
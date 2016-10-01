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
            ConsoleColor OldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;

            AboutProgram();

            Random randomObject = new Random();

            
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine("Ask a question!");

                Console.ForegroundColor = ConsoleColor.Red;

                Console.ForegroundColor = ConsoleColor.DarkGray;
                string QuestionString = Console.ReadLine();

                if (QuestionString.Length == 0)
                {
                    Console.WriteLine("Type a question!");
                    continue;
                }

                if (QuestionString.ToLower() == "you suck")
                {
                    Console.WriteLine("You suck even more! Bye!");
                    break;
                }

                if (QuestionString.ToLower() == "what is the answer to life, the universe and everything")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Thread.Sleep(1000);
                    Console.WriteLine("42");
                    continue;
                }
                
                Console.ForegroundColor = ConsoleColor.Yellow;

                //Console.WriteLine("{0}", randomObject.Next(10) + 1);

                if (QuestionString.ToLower() == "quit")
                {
                    break;
                }

                int RandNum = randomObject.Next(4);

                int RandTime = randomObject.Next(4000);

                switch(RandNum)
                {
                    case 0:
                        {
                            Console.WriteLine("Thinking");
                            Thread.Sleep(RandTime);
                            Console.WriteLine("Yes!");
                            break;
                        }

                    case 1:
                        {
                            Console.WriteLine("Thinking");
                            Thread.Sleep(RandTime);
                            Console.WriteLine("No Way!");
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("Thinking");
                            Thread.Sleep(RandTime);
                            Console.WriteLine("Totally!");
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("Thinking");
                            Thread.Sleep(RandTime);
                            Console.WriteLine("No!");
                            break;
                        }
                }
            }
            

            Console.ForegroundColor = OldColor;
        }
        static void AboutProgram()
 
        { 
            Console.WriteLine("Magic 8 Ball App by Ben Piecora");
        }
      
    }
}

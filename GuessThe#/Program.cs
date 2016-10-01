using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TestConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            AboutProgram();
            
            Console.Write("Pick a low number: ");
            int low_number;
            try
            {
                low_number = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Enter a number next time doofus!");
                return; // exit
            }
            
            int high_number;
            Console.Write("Pick a high number: ");
            try
            {
                high_number = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("You doofus! Enter a number next time!");
                return;
            }

            if (high_number - low_number < 8)
            {
                Console.WriteLine("The difference between the low and high numbers must be at least 8");
                return;
            }

            Random random_number_generator = new Random();
            int lucky_number = random_number_generator.Next(high_number);

            int guesses_left = 10;
            while (guesses_left > 0)
            {
                Console.Write("Take a guess: ");
                int guess;
                try
                {
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Enter a number next time doofus!");
                    continue;
                }
                //continue = doesnt count
                if (guess < low_number || guess > high_number)
                {
                    Console.WriteLine("The number you entered is out of range!");
                    continue;
                }

                if (guess != lucky_number)
                {
                    Console.WriteLine("Try again!");
                }
                else
                {
                    Console.WriteLine("Congratulations! You figured out the lucky number!");

                    int number_of_attempts = 0;
                    bool restart = false;
                    while (!restart)
                    {
                        number_of_attempts++;
                        Console.WriteLine("Would you like to guess a lucky number again? Type yes or no");
                        string readAnswer = Console.ReadLine().ToLower();

                        if (readAnswer.Equals("yes"))
                        {
                            guesses_left = 10;


                            Console.Write("Pick a low number: ");
                            try
                            {
                                low_number = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (System.FormatException)
                            {
                                Console.WriteLine("You doofus! Enter a number next time!");
                                return;
                            }

                            Console.Write("Pick a high number: ");
                            try
                            {
                                high_number = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (System.FormatException)
                            {
                                Console.WriteLine("You doofus! Enter a number next time!");
                                return;
                            }
                            lucky_number = random_number_generator.Next(high_number);
                            restart = true;
                        }
                        else if (readAnswer.Equals("no"))
                        {
                            return;
                        }
                        else
                        {
                            if (number_of_attempts == 1)
                            {
                                ConsoleColor oldColor = Console.ForegroundColor;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("ANSWER YES OR NO DOOFUS!!!!!!!!!!!!");
                                Console.WriteLine("IF YOU DO NOT ANSWER YES OR NO AGAIN PREPARE TO BE TERMINATED!!!!");
                                Console.ForegroundColor = oldColor;
                            }
                            else
                            {
                                ConsoleColor oldColor = Console.ForegroundColor;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("PREPARE TO BE TERMINATED!!!!!!!!!");
                                Thread.Sleep(2000);
                                Console.ForegroundColor = oldColor;
                                return;
                            }
                        }
                    }

                    if (restart)
                    {
                        continue;
                    }
                }

                guesses_left--;
            }
        }   


        static void AboutProgram()
        {
            Console.WriteLine("Guess the Number App by Ben and Jim");
        }
    }
}

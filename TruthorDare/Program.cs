using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruthorDare
{
    class Program
    {
        static void Main(string[] args)
        {
            AboutProgram();

            Console.WriteLine("Truth or Dare");
            
             string readAnswer = Console.ReadLine().ToLower();
            Random random_number_generator = new Random();

           
                        
                        
                          if (random_number_generator.Equals(1))

                          {
                              Console.WriteLine("If you had a time machine, what date would you go to?");

                          }







            static void AboutProgram()
            {
                Console.WriteLine("Truth or Dare by Ben Piecora");
            }
        }
    }
}

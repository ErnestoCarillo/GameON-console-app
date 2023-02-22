using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome in GameON");  
            var GameON = new GameON();

            while (true)
            {
                Console.WriteLine("Give the number");
                var number = GetNumber();
                Console.WriteLine(GameON.GetOutput(number));             
                Console.WriteLine();
            }
        }
        private static int GetNumber()
        {
            while (true)
            {
                
                    
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("You entered wrong date");
                    continue;
                }

               
                    return number;
            }
        }

    }
}

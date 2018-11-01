using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld_new
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            Console.WriteLine("What is your name?");
            userInput = Console.ReadLine();

            Console.WriteLine("Hello World, " + userInput + "!");
            Console.ReadLine();
        }
    }
}

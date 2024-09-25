using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2_MRPO
{
    internal class CLI
    {
        public static string GreetUser()
        {
            Console.WriteLine("Welcome to the Brain Games!");
            Console.Write("May I have your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}", name);
            return name;
        }
    }
}

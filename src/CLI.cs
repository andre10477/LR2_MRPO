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
            //Приветствие
            Console.WriteLine("Welcome to the Brain Games!");
            Console.Write("May I have your name? ");
            
            //Ввод имени
            string name = Console.ReadLine();
            
            //Вывод имени
            Console.WriteLine("Hello, {0}", name);
            return name;
        }
    }
}

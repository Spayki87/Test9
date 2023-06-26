using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Контроль_выхода
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "текст";
            string commandExit = "exit";
            bool isContinue = true;

            while(isContinue == true)
            {
                Console.WriteLine("Введите " + commandExit + ", чтобы выйти.");
                input = Console.ReadLine();

                if(input == commandExit)
                {
                    isContinue = false;
                    Console.WriteLine("Вы вышли из цикла.");
                }
            }
        }
    }
}

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
            string exit = "exit";

            while(input != exit)
            {
                Console.WriteLine("Введите exit, чтобы выйти.");
                input = Console.ReadLine();

                if(input == exit)
                {
                Console.WriteLine("Вы вышли из цикла.");
                }

            }
        }
    }
}

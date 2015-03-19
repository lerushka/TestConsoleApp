using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_valerka
{
    //написать программу которая:
    // принимает на вход строку
    // выводит эти слова в случайном порядке
    class Program
    {
        static string GetInput()
        {
            string str;
            str = Console.ReadLine();
            return str;
        }
        static void Main(string[] args)
        {
            string input = GetInput();
            Console.WriteLine(input);

            //задержка
            Console.ReadKey();
        }
    }
}

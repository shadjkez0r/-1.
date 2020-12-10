using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как Вас зовут?");
            string name=Console.ReadLine();
            Console.Write($"Привет, {name}, сегодня ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(DateTime.Now);

            //Задержка
            Console.ReadKey();
        }
    }
}

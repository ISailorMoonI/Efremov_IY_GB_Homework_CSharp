using System;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя ");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет {name}, текущее время {DateTime.Now} ");
        }
    }
}

using System;
using System.IO;

namespace HW5_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "startup.txt";
            Console.WriteLine("Введите текст");
            string text = Console.ReadLine();
            string timer = DateTime.Now.ToString("F");
            File.WriteAllText(filename, timer + " " + text);
            File.AppendAllText(filename, Environment.NewLine);
            string filetext = File.ReadAllText(filename);
            Console.WriteLine(filetext);
        }
    }
}

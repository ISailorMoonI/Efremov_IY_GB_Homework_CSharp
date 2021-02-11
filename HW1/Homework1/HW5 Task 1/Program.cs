using System;
using System.IO;

namespace HW5_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "text.txt";
            Console.WriteLine("Введите текст");
            string text = Console.ReadLine();
            File.WriteAllText(filename, text);
            File.AppendAllText(filename, Environment.NewLine);
            string filetext = File.ReadAllText(filename);
            Console.WriteLine(filetext);
            

        }
    }
}

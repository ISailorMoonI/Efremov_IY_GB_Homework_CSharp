﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName))
            {

                Console.WriteLine("Введите имя пользователя:");
                Properties.Settings.Default.UserName = Console.ReadLine();
                Properties.Settings.Default.Save();
                Console.WriteLine("Введите возраст");
                Properties.Settings.Default.Age = Convert.ToInt32(Console.ReadLine());
                Properties.Settings.Default.Save();
                Console.WriteLine("Введите род деятельности");
                Properties.Settings.Default.Job = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            string userName = Properties.Settings.Default.UserName;
            int Age = Properties.Settings.Default.Age;
            string Job = Properties.Settings.Default.Job;
            string greeting = Properties.Settings.Default.Greeting;
            Console.WriteLine($"{greeting} , {userName}, {Age}, {Job}");
            Console.ReadKey();

        }
    }
}

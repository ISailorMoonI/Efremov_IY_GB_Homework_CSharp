using System;

namespace HW4_Task_1
{
    class Program
    {
        static (string firstname, string lastname, string petronymic) GetFullName()
        {
            Console.WriteLine("Укажите имя");
            string firstname = Console.ReadLine();
            Console.WriteLine("Укажите фамилию");
            string lastname = Console.ReadLine();
            Console.WriteLine("Укажите отчество");
            string petronymic = Console.ReadLine();
            return (firstname, lastname, petronymic);
        }
        static (string name, string lastname, string petronymic)[] CreateUsers()
        {
            Console.WriteLine("Введите количество пользователей:");
            int count = ReadInt();
            (string firstname, string lastname, string petronymic)[] users = new (string firstname, string lastname, string petronymic)[count];
            for (int i = 0; i < users.Length; i++)
            {
                users[i] = GetFullName();
                Console.WriteLine($"Пользователь {FormatUserData(users[i])} сохранен");
            }

            Console.WriteLine("Ввод данных завершён. Нажмите любую клавишу...");
            Console.ReadKey();
            Console.Clear();

            return users;
        }
        static int ReadInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        static void PrintUser((string firstname, string lastname, string petronymic) user)
        {
            Console.WriteLine(FormatUserData(user));
        }

        static void PrintUsers((string firstname, string lastname, string petronymic)[] users)
        {
            Console.WriteLine("Вывод базы данных:");
            for (int i = 0; i < users.Length; i++)
            {
                PrintUser(users[i]);
            }
        }

        static string FormatUserData((string name, string lastname, string petronymic) user)
        {
            return $"({user.name}) ({user.lastname}) ({user.petronymic})";
        }


        static void Main(string[] args)
        {
            (string firstname, string lastname, string petronymic)[] users = CreateUsers();
            PrintUsers(users);

        }
    }
}

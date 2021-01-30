using System;

namespace HW3_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] contacts = new string[,] 
            { 
                {"lelik", "ebolik@yandex.ru"}, 
                {"biba", "boba@gmail.com"}, 
                { "boka", "joka@sobaka.ru"},
                {"chuk", "cuchuk@kakoitomail.ru"}, 
                {"joka", "legendarniy@mail.ru"}, 
                {"pahom", "bratishka@mail.ru"} 
            };
            for (int i = 0; i < contacts.GetLength(0); i++) 
            {
                for (int j = 0; j < contacts.GetLength(1); j++)
                {
                    Console.WriteLine($"{contacts[i, j]}");
                }
            }
        }
    }
}

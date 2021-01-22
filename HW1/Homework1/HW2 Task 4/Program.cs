using System;

namespace HW2_Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string company = "ИП Зеленый Cлоник";
            var date = DateTime.Now;
            string cashier = "Братишкова И.В"; 
            double hlebushek = 69.99;
            double vilka = 14.78;
            double sum = hlebushek + vilka;
            double payment = 1000;
            double tax = (sum * 10 / 100);
            double change = payment - sum - tax;
            
            Console.WriteLine($"{company}");
            Console.WriteLine($"------------------------------");
            Console.WriteLine($"{date}");
            Console.WriteLine($"{cashier}");
            Console.WriteLine($"------------------------------");
            Console.WriteLine($"Хлебушек сладенький 1x = {hlebushek}");
            Console.WriteLine($"Вилка сантехническая 1х = {vilka}");
            Console.WriteLine($"------------------------------");
            Console.WriteLine($"Итого = {sum}");
            Console.WriteLine($"Внесено наличными = {payment}");
            Console.WriteLine($"НДС {tax}");
            Console.WriteLine($"Cдача {change}");
            


        }
    }
}

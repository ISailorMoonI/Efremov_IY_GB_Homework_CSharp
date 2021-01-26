using System;

namespace HW2_Task_6
{
    class Program
    {
        [Flags]
        public enum WorkWeek
        {
            None         = 0b_0000000,
            Понедельник  = 0b_0000001,
            Вторник      = 0b_0000010,
            Среда        = 0b_0000100,
            Четверг      = 0b_0001000,
            Пятница      = 0b_0010000,
            Суббота      = 0b_0100000,
            Воскресенье  = 0b_1000000,
        }
        static void Main(string[] args)
        {
            WorkWeek FirstOffice =
                WorkWeek.Понедельник |
                WorkWeek.Вторник |
                WorkWeek.Среда |
                WorkWeek.Пятница;

            WorkWeek SecondOffice =
                WorkWeek.Понедельник |
                WorkWeek.Среда |
                WorkWeek.Четверг |
                WorkWeek.Суббота |
                WorkWeek.Воскресенье;

            Console.WriteLine($"Первый офис работает в {FirstOffice} ");
            Console.WriteLine($"Второй офис работает в {SecondOffice}");
        }
    }
}

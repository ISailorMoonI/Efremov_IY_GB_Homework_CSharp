using System;

namespace HW2_Task_1_2_3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите максимальную температуру за день ");
            int maxtemp = Convert.ToInt32 (Console.ReadLine());

            Console.Write("Введите минимальную температуру за день ");
            int mintemp = Convert.ToInt32 (Console.ReadLine());

            double averagetemp = (mintemp + maxtemp) / 2;
            if (averagetemp % 2 == 0)

            Console.WriteLine($"Средняя температура за день {averagetemp} и также является четным числом ");

            else Console.WriteLine($"Средняя температура за день {averagetemp} и также является нечетным числом");

            Console.Write("Введите порядковый номер текущего месяца ");
            int Month = Convert.ToInt32 (Console.ReadLine());
            string MonthTitle ="";
            switch (Month)
            {
                case 1:
                    MonthTitle = "Январь";
                    break;
                case 2:
                    MonthTitle = "Февраль";
                    break;
                case 3:
                    MonthTitle = "Март";
                    break;
                case 4:
                    MonthTitle = "Апрель";
                    break;
                case 5:
                    MonthTitle = "Май";
                    break;
                case 6:
                    MonthTitle = "Июнь";
                    break;
                case 7:
                    MonthTitle = "Июль";
                    break;
                case 8:
                    MonthTitle = "Август";
                    break;
                case 9:
                    MonthTitle = "Сентябрь";
                    break;
                case 10:
                    MonthTitle = "Октябрь";
                    break;
                case 11:
                    MonthTitle = "Ноябрь";
                    break;
                case 12:
                    MonthTitle = "Декабрь";
                    break;
            }
            Console.WriteLine($"Текущий месяц {MonthTitle}");

            if (averagetemp > 0 && (MonthTitle == "Декабрь" || MonthTitle == "Январь" || MonthTitle == "Февраль"))
            {
                Console.WriteLine( "была дождливая зима");
            }
            else if (averagetemp < 0 && (MonthTitle == "Декабрь" || MonthTitle == "Январь" || MonthTitle == "Февраль"))
                {
                Console.WriteLine("была снежная зима");
                }
                
            

        }
    }
}

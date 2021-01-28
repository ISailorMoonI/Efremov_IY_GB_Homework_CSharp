using System;


namespace HW3_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello";
            char[] sReverse = s.ToCharArray();
            Array.Reverse(sReverse);
            s = new string(sReverse);
            Console.WriteLine(s);

        }
    }
}

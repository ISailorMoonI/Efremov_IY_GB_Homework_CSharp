using System;

namespace HW4_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа, разделенные пробелом");
            string[] nums = Console.ReadLine().Split(new char[] {' '});
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int n = Convert.ToInt32(nums[i]);
                sum += n;
            }
            Console.WriteLine(sum);
        }
    }
}

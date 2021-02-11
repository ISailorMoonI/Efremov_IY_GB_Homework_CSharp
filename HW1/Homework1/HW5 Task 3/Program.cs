using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace HW5_Task_3
{
            

    }
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Введите числа, разделенные пробелом");
        string[] nums = Console.ReadLine().Split(new char[] { ' ' });
        byte[] byteNum = new byte[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            int x = int.Parse(nums[i]);
            byte y = Convert.ToByte(x);
            byteNum[i] = y;
        }
        File.WriteAllBytes("Bytes.txt", byteNum);
    }
}


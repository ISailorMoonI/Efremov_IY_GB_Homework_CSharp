﻿using System;

namespace HW3_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                Console.WriteLine(matrix[i, i]);

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    
                }
            }
        }
            
    }
}

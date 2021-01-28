using System;

namespace HW3_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] battleship = new char[10, 10];

             

            for (int i = 0; i < battleship.GetLength(0); i++)
            {
                for (int j = 0; j < battleship.GetLength(1); j++)
                {
                    
                    battleship[i, j] = 'O';
                    battleship[5, 5] = 'X';
                    battleship[8, 7] = 'X';
                    battleship[3, 1] = 'X';
                    battleship[4, 9] = 'X';
                    battleship[3, 5] = 'X';
                    battleship[2, 9] = 'X';
                    battleship[9, 1] = 'X';
                    battleship[6, 5] = 'X';
                    battleship[0, 6] = 'X';
                    battleship[7, 2] = 'X';
                    battleship[7, 1] = 'X';
                    Console.Write($"{battleship[i, j]}");
                }
                Console.WriteLine();
            }
        }
        
    }
}

//int[,] matrix = new int[5, 5];

//matrix[2, 2] = 1;

//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//       System.Console.Write($"{matrix[i, j]} ");
//    }
 //   System.Console.WriteLine();
//}

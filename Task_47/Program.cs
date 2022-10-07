﻿using static System.Console;
Clear();

// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

WriteLine("Задайте размера массива");
WriteLine("Строки: ");
int m = int.Parse(ReadLine()!);
WriteLine("Столбцы: ");
int n = int.Parse(ReadLine()!);

double[,] matrix = new double[m, n];

WriteLine();
FillRandomNumbers(matrix);
PrintArray(matrix);

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]:f1}" + "\t");
        }
        Console.WriteLine();
    }
}

double[,] FillRandomNumbers(double[,] matr)
{
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.NextDouble()+rand.Next(-10,10);
        }
    }
    return matr;
}

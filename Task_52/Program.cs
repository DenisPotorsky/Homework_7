using static System.Console;
Clear();
//  1. Задайте двумерный массив из целых чисел. 
//  2. Найдите среднее арифметическое элементов в каждом столбце.
//  Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; i.
WriteLine("Задайте размер массива");
WriteLine("Строки: ");
int a = int.Parse(ReadLine()!);
WriteLine("Столбцы: ");
int b = int.Parse(ReadLine()!);
int[,] arr = CreateArray(a, b);
PrintArray(arr);
WriteLine();
ColumnsSum(arr);

int[,] CreateArray(int rows, int col)

{
    Random rnd = new Random();
    int[,] array = new int[rows, col];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ColumnsSum(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        sum /= array.GetLength(0);
        Write($"{sum:f1}; ");
    }
}
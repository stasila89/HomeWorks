﻿// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
int rows = StringMessage("Введите rows: ", "Ошибка ввода.");
int col = StringMessage("Введите col: ", "Ошибка ввода.");
double[,] array = new double[rows, col];
RandomArray(array);
PrintArray(array);


void RandomArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-10, 10)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}

int StringMessage(string msg, string error)
{
    while (true)
    {
        Console.Write(msg);
        bool IsCorrect = int.TryParse(Console.ReadLine(), out int kek);
        if (IsCorrect)
        {
            return kek;
        }
        Console.WriteLine(error);
    }
}
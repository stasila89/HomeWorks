﻿//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
int length = GetNumberFromUser("Введите длину массива: ", "Ошибка ввода!");
int min = GetNumberFromUser("Введите начальное значение диапазона: ", "Ошибка ввода!");
int max = GetNumberFromUser("Введите конечное значение диапазона: ", "Ошибка ввода!");
int[] array = GetArray(length, min, max);

int sum = GetSumOddPosition(array);
Console.WriteLine($"[{String.Join(", ", array)}] -> [{String.Join(", ", sum)}]");

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int GetSumOddPosition(int[] array)
{
    sum = 0;
    for (int i = 0; i < length; i += 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

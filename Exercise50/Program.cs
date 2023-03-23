// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();
int rows = StringMessage("Введите rows: ", "Ошибка ввода.");
int col = StringMessage("Введите col: ", "Ошибка ввода.");
int rowNumber = StringMessage("Введите номер элемента в строке: ", "Ошибка ввода.");
int colNumber = StringMessage("Введите номер элемента в столбце: ", "Ошибка ввода.");
int[,] array = GetArray(rows, col);
PrintArray(array);


if (rowNumber > array.GetLength(0) || colNumber > array.GetLength(1))
{
    Console.WriteLine($"{rowNumber}, {colNumber} -> такого элемента нет");
}
else
{
    Console.WriteLine($"{rowNumber}, {colNumber} -> {array[rowNumber - 1, colNumber - 1]}");
}

int[,] GetArray(int rows, int col)
{
    int[,] arr = new int[rows, col];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-100, 100);
        }
    }
    return arr;
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
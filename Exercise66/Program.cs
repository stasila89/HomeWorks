// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30
Console.Clear();
int n = GetNum("Введите натуральное значение N", "Ошибка ввода!");
int m = GetNum("Введите натуральное значение M", "Ошибка ввода!");
int result = GetResult(n, m);
Console.WriteLine(result);


int GetNum(string message, string error)
{
    while (true)
    {
        Console.WriteLine(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
        if (isCorrect && num > 0) return num;
        else Console.WriteLine(error);
    }
}

int GetResult(int n, int m)
{
    if (n == m) return n;
    {
        return n  + GetResult(n+1, m);
    }
}
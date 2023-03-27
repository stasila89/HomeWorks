// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.Clear();
int m = GetNum("Введите натуральное значение M", "Ошибка ввода!");
int n = GetNum("Введите натуральное значение N", "Ошибка ввода!");
Akkerman(m,n);


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

void Akkerman(int m, int n)
{
    Console.Write(FunctionAkkerman(m, n)); 
}

int FunctionAkkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return FunctionAkkerman(m - 1, 1);
    }
    else
    {
        return (FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1)));
    }
}

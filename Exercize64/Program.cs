// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до M.
// M = 1; N = 5. -> “5, 4, 3, 2, 1"
// M = 4; N = 8. -> “8, 7, 6, 5, 4"
Console.Clear();
int M = GetNum("Введите натуральное значение M ", "Ошибка ввода!");
int N = GetNum("Введите натуральное значение N ", "Ошибка ввода!");
string result = PrintResult(M, N);
Console.WriteLine(M > N ? "Ошибка ввода" : $"M = {M}; N = {N}. -> {result}");


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

string PrintResult(int M, int N)
{
    if (N == M) return N.ToString();
    return (N + " " + PrintResult(M, N - 1));
}

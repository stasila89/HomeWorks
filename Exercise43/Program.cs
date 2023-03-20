// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();
double b1 = InputNumber("Введите b1: ", "Ошибка ввода числа!");
double k1 = InputNumber("Введите k1: ", "Ошибка ввода числа!");
double b2 = InputNumber("Введите b2: ", "Ошибка ввода числа!");
double k2 = InputNumber("Введите k2: ", "Ошибка ввода числа!");

double[] crossPoint = GetCrossPoint(k1, b1, k2, b2);

PrintResult(k1, b1, k2, b2, crossPoint);

static double InputNumber(string msg, string msgError)
{
    double num;
    while (true)
    {
        try
        {
            Console.Write(msg);
            num = double.Parse(Console.ReadLine() ?? "");
            break;
        }
        catch (Exception exc)
        {
            Console.WriteLine($"{msgError} {exc.Message}");
        }
    }
    return num;
}

static double[] GetCrossPoint(double k1, double b1, double k2, double b2)
{
    double[] result = new double[3];
    if (k1 == k2 && b1 == b2) result[0] = -1;
    else if (k1 == k2) result[0] = 0;
    else
    {
        result[0] = 1;
        double x = (b2 - b1) / (k1 - k2);
        result[1] = Math.Round(x, 1);
        result[2] = Math.Round(x * k1 + b1, 1);
    }
    return result;
}

static void PrintResult(double k1, double b1, double k2, double b2, double[] result)
{
    Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ");
    if (result[0] == 1) Console.WriteLine($"({result[1]}; {result[2]})");
    else if (result[0] == 0) Console.WriteLine("Прямые параллельны");
    else Console.WriteLine("Прямые совпадают");
}


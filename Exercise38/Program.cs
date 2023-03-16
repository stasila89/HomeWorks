// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.Clear();
int length = GetNumberFromUser("Введите длину массива: ", "Ошибка ввода!");
double[] array = GetArray(length);
double max = MaxValue(array);
double min = MinValue(array);

Console.WriteLine($"Максимальное число ->  {max}");
Console.WriteLine($"Минималдьное число ->  {min}");
Console.WriteLine($"[{String.Join(", ", array)}] -> [{String.Join(", ", max - min)}]");


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

double[] GetArray(int length)
{

    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = (new Random().NextDouble()) * 100;
    }
    return array;
}

double MaxValue(double[] array)
{
    double max = 0;

    for (int i = 0; i < array.Length; i++)

    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double MinValue(double[] array)
{
    double min = max;

    for (int i = 0; i < array.Length; i++)

    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}
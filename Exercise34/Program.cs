//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
Console.Clear();
int[] array = GetArray(10, 100, 1000);
int result = EvenNumbers(array);
Console.WriteLine($"[{String.Join(", ", array)}] -> {result}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int EvenNumbers(int[] array)
{
    int count = 0;
    foreach (int el in array)
    {
        if (el %2 == 0)
            count++;
    }
    return count;
}
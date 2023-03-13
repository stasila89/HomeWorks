Console.Clear();
Console.WriteLine("Введите число A: ");
int numberA = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите число B: ");
int numberB = int.Parse(Console.ReadLine() ?? "");

int exponent = Exponent(numberA, numberB);

int Exponent(int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    return result;
}

Console.WriteLine($"{numberA} в степени {numberB} -> {exponent}");
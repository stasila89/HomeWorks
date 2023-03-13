Console.Clear();
Console.WriteLine("Введите число: ");
int number;
while (true)
{
    if (int.TryParse(Console.ReadLine(), out number))
        break;
    Console.WriteLine("Ошибка ввода");
}

int sumNumber = SumNumber(number);

int SumNumber(int number)
{

    int counter = Convert.ToString(number).Length; ;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
        advance = number - number % 10;
        result = result + (number - advance);
        number = number / 10;
    }
    return result;
}

Console.WriteLine($"Сумма цифр числа {number} -> {sumNumber}");

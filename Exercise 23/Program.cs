Console.Clear ();
Console.WriteLine("Введите число: ");
int number;
while (true)
{
    if (int.TryParse(Console.ReadLine(), out number))
        break;
    Console.WriteLine("Ошибка ввода");
}
Console.WriteLine($"Кубы чисел от 1 до {number} будут: ");
for (int i=1;i<=number;i++)
{
int Cube = i*i*i;
Console.WriteLine($"{Cube}");
}
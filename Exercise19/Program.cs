Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int a;
while (true)
{
    if (int.TryParse(Console.ReadLine(), out a))
        break;
    Console.WriteLine("Ошибка ввода");
}
int a1 = a / 10000;
int a2 = a / 1000 % 10;
int a3 = a / 10 % 10;
int a4 = a % 10;
if ((a < 10000) || (a > 100000)) Console.WriteLine("Введено неверное число!");
else if ((a1 == a4) && (a2 == a3)) Console.WriteLine($"Число {a} -> палиндром");
else Console.WriteLine($"Число {a} -> не палиндром");
Console.WriteLine("Введите любое целое число");
int UserNumber = int.Parse(Console.ReadLine() ?? "");

if (UserNumber % 2 == 0) Console.WriteLine($"{UserNumber} -> является четным");
else
    Console.WriteLine($"{UserNumber} -> не является четным");


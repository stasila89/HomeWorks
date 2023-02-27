Console.WriteLine("Введите любое целое число");
int a = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите второе целое число");
int b = int.Parse(Console.ReadLine() ?? "");

if (a > b) Console.WriteLine($"{a} -> максимальное");
else if (b > a) Console.WriteLine($"{b} -> максимальное");
else if (a == b) Console.WriteLine($"{a} и {b} -> равны между собой!");

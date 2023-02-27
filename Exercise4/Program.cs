Console.WriteLine("Введите любое целое число");
int a = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите второе целое число");
int b = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите третье целое число");
int c = int.Parse(Console.ReadLine() ?? "");

if (a > b && a > c) Console.WriteLine($"{a} {b} {c} -> {a} - максимальное");
else
if (b > a && b > c) Console.WriteLine($"{a} {b} {c} -> {b} - максимальное");
else
if (c > a && c > b) Console.WriteLine($"{a} {b} {c} -> {c} - максимальное");

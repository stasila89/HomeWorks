Console.WriteLine("Введите любое целое число");
int UserNumber = int.Parse(Console.ReadLine() ?? "");
int number =1;

while (number <=UserNumber)
{
    if((number%2==0)) Console.WriteLine(number);
    number++;
}

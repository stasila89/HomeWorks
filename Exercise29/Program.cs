Console.Clear();
int[] array = new int[8];

FillArray(array);
PrintArray(array);

void FillArray(int[] collection) 
{
    int Length = 8;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(0, 100);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
Console.WriteLine($" -> [{String.Join(",", array)}]");

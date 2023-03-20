// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Clear();
 int userNumber = InputNumber("Введите количество чисел (М): ", "Ошибка ввода!");
 int[] array = InputArray(userNumber);
 
 int countNumbersMoreZero = GetNumbersMoreZero(array);

 PrintResult(array, countNumbersMoreZero);


 static int InputNumber(string msg, string msgError)
 {
     int num;
     while (true)
     {
         try
         {
             Console.Write(msg);
             num = int.Parse(Console.ReadLine() ?? "");
             if (num > 0) break;
             Console.WriteLine(msgError);
         }
         catch (Exception exc)
         {
             Console.WriteLine($"{msgError} {exc.Message}");
         }
     }
     return num;
 }

 static int InputInteger(string msg, string msgError)
 {
     int num;
     while (true)
     {
         try
         {
             Console.Write(msg);
             num = int.Parse(Console.ReadLine() ?? "");
             break;
         }
         catch (Exception exc)
         {
             Console.WriteLine($"{msgError} {exc.Message}");
         }
     }
     return num;
 }

 static int[] InputArray(int size)
 {
     int[] arr = new int[size];
     for (int i = 0; i < size; i++)
     {
         arr[i] = InputInteger($"Введите число {i + 1} из {size}: ", "Ошибка ввода числа!");
     }
     return arr;
 }

 static int GetNumbersMoreZero(int[] arr)
 {
     int result = 0;
     foreach (int num in arr)
         if (num > 0) result++;

     return result;
 }

 static void PrintResult(int[] arr, int num)
 {
     Console.WriteLine($"{String.Join(", ", arr)} -> {num}");
 }
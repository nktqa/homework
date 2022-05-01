// Задача 41. Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число");
int number3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число");
int number4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число");
int number5 = Convert.ToInt32(Console.ReadLine());

int[] array = {number1, number2, number3, number4, number5};
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) count++;
}

Console.Write($"количество четных чисел: {count}");
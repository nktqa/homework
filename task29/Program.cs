// Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел 
// и выводит отсортированный по модулю массив.

Random rand = new Random();
int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-5, 5);
    Console.Write(Math.Abs(array[i]));
    Console.Write(" ");
}
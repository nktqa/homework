// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = new int[7];
FillArray();
PrintArray();
Search();

void Search()
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) count += array[i];
    }
    Console.Write(count);
}

void FillArray()
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(1, 10);
    }
    Console.WriteLine();
}

void PrintArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
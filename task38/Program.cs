// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.

double[] array = new double[7];
FillArray();
PrintArray();
Search();

void Search()
{
    double maxNum = array[0];
    double minNum = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (maxNum < array[i])
        {
            maxNum = array[i];
        }
        if (minNum > array[i])
        {
            minNum = array[i];
        }
    }
    Console.WriteLine($"макс {maxNum}, мин {minNum}");
    Console.Write($"раздница между {maxNum} и {minNum} = {maxNum - minNum}");
}

void FillArray()
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.NextDouble() * 100;
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
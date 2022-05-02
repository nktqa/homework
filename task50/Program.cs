// Задача 50: Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет.

Console.WriteLine("введите строку: ");
int stroka = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите столбец: ");
int stolbec = Convert.ToInt32(Console.ReadLine());
//Денис, если есть другие варианты первых четырех строк кода, то буду благодарен за полезную информацию в ответе по оценке дз на сайте

int rows = 10;
int columns = 10;

int[,] array = new int[rows, columns];
FillArray();
PrintArray();

if (stroka < 0 | stroka > array.GetLength(0) - 1 | stolbec < 0 | stolbec > array.GetLength(1) - 1)
{
    Console.WriteLine("такого элемента нет");
}
else Console.WriteLine($"искомое число {array[stroka, stolbec]}");

void FillArray()
{
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = rand.Next(1,100);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}
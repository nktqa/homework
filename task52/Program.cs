// Задача 52: Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

int rows = 4;
int columns = 4;

int[,] array = new int[rows, columns];
FillArray();
PrintArray();
Search();

// Денис, решил задачу кустарным способом, не понимаю как обнулить счетчик
//после перехода на следующий столбец
//буду рад подсказке

void Search()
{
    double ave = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            ave += array[j,i];
        }
        Console.Write(ave / columns + " ");
        ave = 0;
        
    }
    
}

void FillArray()
{
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = rand.Next(0,100);
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
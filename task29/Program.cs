// Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел 
// и выводит отсортированный по модулю массив.

Random rand = new Random();
int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-50, 50);
}

BubbleSort(array);

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}


void BubbleSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - 1; j++)
        {
            if (Math.Abs(array[j]) > Math.Abs(array[j + 1]))
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
}
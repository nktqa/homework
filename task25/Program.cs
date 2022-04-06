// Задача 25: Напишите цикл, который принимает на вход два натуральных числа (A и B) 
// и возводит число A в степень B.

Console.WriteLine("введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число В: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int summ = 1;

for (int i = 0; i < numberB; i++)
{
    summ *= numberA;
}
Console.WriteLine(summ);


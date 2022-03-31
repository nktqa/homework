// Задача 23: Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

Random rand = new Random();
int number = rand.Next(1, 999);
Console.WriteLine(number);

for (int i = 1; i < number; i++)
{
    double rezultat = Math.Pow(i, 3);
    Console.WriteLine(rezultat);
}
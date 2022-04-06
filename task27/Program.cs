// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

Console.WriteLine("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int chislo = 1;
int summa = 0;

while (number > 0)
{
    chislo = number % 10;
    number /= 10;
    summa += chislo;
}
Console.WriteLine(summa);
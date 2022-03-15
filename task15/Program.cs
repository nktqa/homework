/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.*/
int number = new Random().Next(1,8);
Sleep(number);


void Sleep(int currentNumber)
{
    if(currentNumber <= 5)
    {
        Console.WriteLine($"{currentNumber} это рабочий день");
    }
    else
    {
        Console.WriteLine($"{currentNumber} это ВЫХОДНОЙ!");
    }
}
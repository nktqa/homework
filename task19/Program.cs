// Задача 19: Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

Console.WriteLine("введите пятизначное число: ");
string number = Console.ReadLine();

if (number[0] == number[4] && number[1] == number[3])
{
    Console.WriteLine("это число - паралиндром");
}
else
{
    Console.WriteLine("это чисто не палиндром");
}
/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.*/
int number = new Random().Next(1,99999);
raschet(number);

void raschet(int current_number)
{
    if (current_number > 99)
    {
        Console.WriteLine($"третьей цифрой числа {current_number} является цифра {number.ToString()[2]}");
    }
    else
    {
        Console.WriteLine($"у числа {current_number} нет третьей цифры");
    }
}
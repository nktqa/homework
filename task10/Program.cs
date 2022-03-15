//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе выводит перевёрнутое число.
Console.WriteLine("введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Perevorot(number);

void Perevorot(int current_number)
{
    int lastNumber = current_number % 10;
    int secondNumber = (current_number / 10) % 10;
    int firstNumber = current_number / 100;
    Console.WriteLine(lastNumber + "" + secondNumber + "" + firstNumber);
}
/*
Random rand = new Random();

for (int i = 0; i < 10; i++)
{
    int number = rand.Next(10, 100);
    Sravnenie(number);
}

void Sravnenie(int current_number)
{
    int t_place = current_number / 10;
    int d_place = current_number % 10;

    if (t_place > d_place)
    {
        Console.WriteLine(current_number + " >> " + t_place);
    }
    else
    {
        Console.WriteLine(current_number + " >> " + d_place);
    }
}
*/
Console.WriteLine("введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine("максимальное число " + number1);
    Console.WriteLine("минимальное число " + number2);
}
else
{
    Console.WriteLine("максимальное число " + number2);
    Console.WriteLine("минимальное число " + number1);
}
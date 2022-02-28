Console.WriteLine("введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max;

if (number1 > number2)
{
    max = number1;
}
else
{
    max = number2;
}
if (max > number3)
{
    Console.WriteLine("максимальное число " + max);
}
else
{
    Console.WriteLine("максимальное число " + number3);
}
// Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

Random rand = new Random();

int a_x = rand.Next(1, 10);
int a_y = rand.Next(1, 10);
int b_x = rand.Next(1, 10);
int b_y = rand.Next(1, 10);
int c_x = rand.Next(1, 10);
int c_y = rand.Next(1, 10);

Console.WriteLine("точка А - " + a_x + ":" + a_y);
Console.WriteLine("точка B - " + b_x + ":" + b_y);

double rasst = Math.Sqrt(Math.Pow(a_x - b_x, 2) + Math.Pow(b_x - b_y, 2) + Math.Pow(c_x - c_y, 2));
Console.WriteLine("расстояние между ними в 3d пространстве " + rasst);
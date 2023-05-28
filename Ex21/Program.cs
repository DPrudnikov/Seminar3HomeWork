// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве

Console.Clear();
Console.WriteLine("Введите координаты точки 1 ");
Console.WriteLine("x1 ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y1 ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("z1 ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки 2 ");
Console.WriteLine("x2 ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y2 ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("z2 ");
int z2 = Convert.ToInt32(Console.ReadLine());

double R = (x2 - x1) + (y2 - y1) + (z2 - z1);

Console.WriteLine(R);
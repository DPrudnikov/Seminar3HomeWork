// Напишите программу, которая принимает на вход число (N)
// и выдает таблицу кубов чисел  от 1 до N.

Console.Clear();
Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
double num = 0;
int i = 0;

while (i<N)
{
    Console.WriteLine(num = Math.Pow ((i + 1),3));
    i = i + 1;  
}
Console.WriteLine("End");
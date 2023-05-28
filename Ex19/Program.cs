// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом

Console.Clear();
Console.WriteLine("Введите число >10000 и <100000 ");
int N = Convert.ToInt32(Console.ReadLine());

int num1 = N % 10;
int num2 = N / 10000;
int num3 = (N / 10) % 10;
int num4 = (N / 1000) % 10;

if ((num1 == num2) && (num3 == num4) && (num1 + num3 == num2 + num4))
{
    Console.WriteLine("Полиндром");
}
else
{
    Console.WriteLine("Не полиндром");
}
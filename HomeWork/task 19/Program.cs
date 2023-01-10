// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом. Через строку решать нельзя.
Console.WriteLine("введите число ");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n; int n2 = n;
int m = 0;
while (n > 0)
{
    n1 = n % 10;
    m = m * 10 + n1;
    n = n / 10;
}
if (m == n2)
{
    Console.WriteLine("это палиндром");
}
else Console.WriteLine("это не палиндром");
// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.WriteLine("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a > 100 && a <= 1000)
{
    int b = a % 10;
    Console.WriteLine("Последняя цифра: " + b);
}
else
    Console.WriteLine("Число не трехзначное");
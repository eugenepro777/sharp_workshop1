// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю
//  цифру этого числа.

Console.WriteLine("Введите трехзначное число: ");
int numIn = Convert.ToInt32(Console.ReadLine());

if (numIn > 100 && numIn <= 1000)
{
    int numOut = numIn % 10;
    Console.WriteLine("Последняя цифра: " + numOut);
}
else
{
    Console.WriteLine("Число не трехзначное");
}
    
Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int numberC = (numberB*numberB);

if (numberA == numberC)
{
    Console.WriteLine("Да");
}
else 
{
    Console.WriteLine("Нет");
}
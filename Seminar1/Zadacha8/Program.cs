// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());
int сount = 0;
if (number<0)
{
    while (сount>number)
    {
        сount = сount-2;
        Console.Write($"{сount}, ");
    }
}
else
{
   while (сount<number)
    {
        сount = сount+2;
        Console.Write($"{сount}, ");
    } 
}
Console.Write("\b\b.");
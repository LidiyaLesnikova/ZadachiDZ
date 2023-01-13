// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());
int сount = 2;
while (сount<=number)
{
    Console.Write($"{сount}, ");
    сount = сount+2; 
}
Console.Write("\b\b.");
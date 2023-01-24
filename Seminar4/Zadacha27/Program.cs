// Задача 27: Напишите программу, которая принимает на вход число и выдаёт 
// сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр числа {num} = {Sum(num)}");

int Sum(int number)
{
    int sumnumber = 0;
    while (number != 0) //не равно нулю
    {
        sumnumber += number % 10;
        number /= 10;
    }
    return sumnumber;
}
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите два числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {a} в степени {b} = {Math.Pow(a, b)}"); //через функцию
Console.WriteLine($"Число {a} в степени {b} = {Degree(a, b)}"); //через метод

double Degree(int num1, int num2)
{
    double rezult = 1;
    if (num2 < 0)
    {
        for (int i = -1; i >= num2; i=i-1)
        {
            rezult *= num1;
        }
        rezult = 1/rezult;
    }
    else 
    {
        for (int i = 1; i <= num2; i++)
        {
            rezult *= num1;
        }
    }
    return rezult;
}
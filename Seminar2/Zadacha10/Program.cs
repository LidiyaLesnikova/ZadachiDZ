// Задача 10: Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
//int num = new Random().Next(100, 1000);
Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num>99&&num<1000) Console.WriteLine($"{num} -> {num / 10 % 10}");
else Console.WriteLine("Это не трехзначное число (((");
﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
string num = Console.ReadLine()!;
if (num.Length<3) Console.WriteLine($"{num} -> третьей цифры нет");
else Console.WriteLine($"{num} -> третья цифра: {num[2]}");
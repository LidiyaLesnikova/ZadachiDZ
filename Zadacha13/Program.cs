// Задача 13: Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
string num = Console.ReadLine()!;
int priznak = 3; //положительное
if (Convert.ToInt32(num)<0) priznak = 4; //отрицательное
if (num.Length<priznak) Console.WriteLine($"{num} -> третьей цифры нет");
else Console.WriteLine($"{num} -> третья цифра: {num[priznak-1]}");
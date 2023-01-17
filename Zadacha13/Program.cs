// Задача 13: Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Write("Введите число: ");
string num = Console.ReadLine();
string[] array = num.ToCharArray();
//string[] array = new Convert.ToString(num);
if (array.Length<3) Console.WriteLine($"{num} -> третьей цифры нет");
else Console.WriteLine($"{num} -> {array[2]}");
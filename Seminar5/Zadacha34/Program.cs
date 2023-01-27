// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Задайте размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[N];
int count = FillArray(arr);
Console.Write($" -> {count}");

int FillArray(int[] arr)
{
    count = 0;
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
        Console.Write($"{arr[i]}, ");
        if (arr[i]%2==0) count++;
    }
    Console.Write("\b\b]");
    return count;
}
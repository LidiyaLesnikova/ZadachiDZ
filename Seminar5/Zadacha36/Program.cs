// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Задайте размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[N];
int sum = FillArray(arr);
Console.Write($" -> {sum}");

int FillArray(int[] arr)
{
    sum = 0;
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-10, 11);
        Console.Write($"{arr[i]}, ");
        if (i%2==1) sum += arr[i];
    }
    Console.Write("\b\b]");
    return sum;
}
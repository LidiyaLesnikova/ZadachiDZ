// Задача 38: Задайте массив целых чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Задайте размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввести массив вручную - 1 или автоматом: ");
string query = Console.ReadLine()!;

int[] arr = new int[N];
int diff = FillArray(arr, query);
Console.Write($" -> разница {diff}");

int FillArray(int[] arr, string? query)
{
    int min = 0;
    int max = 0;
    if (query != "1") Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (query == "1")
        {
            Console.Write($"Элемент {i+1}: ");
            string c = Console.ReadLine()!;
            if (c=="") arr[i] = 0;
            else arr[i] = Convert.ToInt32(c);
        }
        else 
        {
            arr[i] = new Random().Next(0, 101);
            // double num = (new Random().NextDouble())*10;
            // Console.WriteLine(Math.Round(num,2));
            Console.Write($"{arr[i]}, ");
        }
        if (i==0)
        {
            max = arr[i];
            min = arr[i];
        }
        if (arr[i]>max) max = arr[i];
        if (arr[i]<min) min = arr[i];
    }
    if (query != "1") Console.WriteLine("\b\b]");
    Console.Write($"макс = {max}, миним = {min}");
    int diff = max - min;
    return diff;
}
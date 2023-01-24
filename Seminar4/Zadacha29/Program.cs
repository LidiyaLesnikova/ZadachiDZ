// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
//*напишите программу, которая задает массив из N элементов в заданном 
//пользователем диапазоне и выводит их на экран

Console.Write("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите диапазон чисел для элементов массива от: ");
int start = Convert.ToInt32(Console.ReadLine());
Console.Write("до: ");
int finish = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N];

UserArray(array, start, finish); //введение массива пользователем
ShowArray(array);
Console.WriteLine();
RandomArray(array, start, finish); //рандомный массив
ShowArray(array);

void UserArray(int[] array, int on, int off)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Элемент {i+1}: ");
        int temp = Convert.ToInt32(Console.ReadLine());
        while (temp < on || temp > off)
        {
            Console.Write("!!!Элемент вне диапазона, введите заново: ");
            temp = Convert.ToInt32(Console.ReadLine());
        }
        array[i] = temp;
    }
}

void RandomArray(int[] array, int on, int off)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(on, off + 1);
    }
}

void ShowArray(int[] arr)
{
    Console.Write($"[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"\b\b]");
}

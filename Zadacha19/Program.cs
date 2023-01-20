// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num>9999&&num<100000)
{
    //Вариант со строкой
    string str = num.ToString();
    if (str[0]==str[4]&&str[1]==str[3])
    Console.WriteLine($"Число {num} -> да, это полиндром");
    else Console.WriteLine($"Число {num} -> нет, это не полиндром");

    //Вариант с числами
    if ((num/10000==num%10) && (num/1000%10==num/10%10))
        Console.WriteLine($"Число {num} -> да, это полиндром");
    else Console.WriteLine($"Число {num} -> нет, это не полиндром");
} 
else Console.WriteLine("Это не пятизначное число (((");
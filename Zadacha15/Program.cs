// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

string PrintNumber(int number)
{   
    string rezult;
    if (number==7||number==6) rezult = "да - это выходной";
    else rezult = "нет - это рабочий день";
    return rezult;
}

Console.Write("Введите номер для недели: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num>0&&num<8) Console.WriteLine($"{num} -> {PrintNumber(num)}");
else Console.WriteLine("Номер дня недели только от 1 до 7 (((");
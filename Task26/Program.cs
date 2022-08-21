// Задача 26: Напишите программу, которая 
// 1. принимает на вход число и 
// 2. выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int CountNumbers(int number)
{
int i = 0;
if (num < 0)
{
    num = -num;
}

while (num >= 1)
{
    num = num / 10;
    i++;
}
return i;
}
int res = CountNumbers(num);
Console.WriteLine($"Количество цифр в числе {num} = {res}");
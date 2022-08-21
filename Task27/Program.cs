// Задача 27: Напишите программу, которая 
// 1. принимает на вход число и 
// 2. выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());

int SumDigit(int number)
{
    int sum = 0;
    while (number >= 10)
    {
        sum = number % 10 + sum;
        number = number / 10;
    }
    return sum + number;
}
Console.WriteLine($"Сумма цифр в числе {num} равна {SumDigit(num)}.");
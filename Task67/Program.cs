// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int SumDigit(int num)
{
    if (num/10 <= 0) return sum +=num % 10;
    sum += SumDigit(num/10);
    return sum += num % 10;
}

int res = SumDigit(number);
Console.WriteLine(res);
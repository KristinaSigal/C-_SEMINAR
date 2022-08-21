// Задача 10: Напишите программу, которая 
//      1. принимает на вход трёхзначное число и 
//      2. на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число.");
int number = Convert.ToInt32(Console.ReadLine());

int MidleDigit(int num)
{
    int midleDigit = (num / 10) % 10;
    return midleDigit > 0 ? midleDigit : midleDigit * -1;
}

int res = MidleDigit(number);
Console.WriteLine(res);
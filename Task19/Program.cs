// Задача 19: Напишите программу, которая 
// 1. принимает на вход пятизначное число и 
// 2. проверяет, является ли оно палиндромом.
// 142192 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите целое пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

while (number / 10000 > 9 || number / 10000 < 1)
{
    Console.WriteLine("Ошибка ввода");
    Console.WriteLine("Введите целое пятизначное число");
    number = Convert.ToInt32(Console.ReadLine());
}

string CompareDigit(int num)
{
    if (num / 10000 != num % 10) return "Число не являтся палиндромом";
    if (num / 1000 % 10 != num % 100 / 10) return "Число не являтся палиндромом";
    return "Число являтся палиндромом";
}

Console.WriteLine(CompareDigit(number));
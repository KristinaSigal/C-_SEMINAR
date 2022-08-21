// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;
int min = b;


if (a > b)
{
    max = a; min = b;
}
else
{
    max = b; min = a;
}

Console.Write("Максимальным является число ");
Console.Write(max);
Console.Write(", минимальным число ");
Console.WriteLine(min);
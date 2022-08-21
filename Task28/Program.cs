// Задача 28: Напишите программу, которая
// 1. принимает на вход число N и 
// 2. выдаёт произведение чисел от 1 до N.
//     4 -> 24
//     5 -> 120

int MultNum(int n)
{
    int m = 1;
    for (int i = 1; i <= n; i++)
    {
        m *= i; // m*=i то же что и m*i
    }
    return m;
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int mult = MultNum(num);
Console.WriteLine($"Произведение чисел от 1 до {num} = " + mult);
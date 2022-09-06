// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.WriteLine("Введите первое целое число: ");
int firstnumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе положительное число: ");
int secondnumber = Convert.ToInt32(Console.ReadLine());

void NaturalNumberBetween(int m, int n)
{
    if (m == n)
    {
        Console.Write($"{m} ");
        return;
    }
    if (m > n)
    {
        Console.Write($"{m} ");
        NaturalNumberBetween(m - 1, n);
    }
    else
    {
        NaturalNumberBetween(m, n - 1);
        Console.Write($"{n} ");
    }
}

NaturalNumberBetween(firstnumber, secondnumber);

// void NaturalNumberBetween(int num1, int num2)
// {
//     if (num1 == num2)
//     {
//         Console.Write($"{num2} ");
//         return;
//     }
//     NaturalNumberBetween(num1, num2 - 1);
//     Console.Write($"{num2} ");
// }

// void NaturalNumberBetween2(int num1, int num2)
// {
//     if (num1 == num2)
//     {
//         Console.Write($"{num1} ");
//         return;
//     }
//     NaturalNumberBetween(num2, num1 - 1);
//     Console.Write($"{num1} ");
// }
// if (firstnumber > secondnumber)
// {
//     NaturalNumberBetween2(firstnumber, secondnumber);
// }
// else NaturalNumberBetween(firstnumber, secondnumber);

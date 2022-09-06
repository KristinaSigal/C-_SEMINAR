// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8 

Console.WriteLine("Введите первое целое число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе положительное число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

// int Rate(int a, int b)
// {
//     int res = a;
//     if (b == 0) return 1;
//     else
//     {
//         res *= Rate(a, b - 1);
//     }
//     return res;
// }

int Rate(int a, int b)
{
    if (b == 0) return 1;
    return a * Rate(a, b-1);
}

int resulst = Rate(numberA, numberB);
Console.WriteLine(resulst);
// Задача 25: Напишите цикл, который 
// 1. принимает на вход два числа (A и B) и 
// 2. возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
int b;
do {
    Console.WriteLine("Введите второе натуральное число");
    b = Convert.ToInt32(Console.ReadLine());
    }
    while (b < 0);

int rate = 1;
for (int i = 0; i < b; i++)
{
    rate = rate*a;
}

Console.WriteLine($"Число {a} в степени {b} равно {rate}.");
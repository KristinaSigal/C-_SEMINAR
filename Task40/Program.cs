// Задача 40: Напишите программу, которая 
// 1. принимает на вход три числа и 
// 2. проверяет, может ли существовать треугольник с сторонами такой длины.

// Теорема о неравенстве треугольника: 
// каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());

bool CheckTriangle(int a1, int b1, int c1)
{
    // if (a1 + b1 > c1 && a1 + c1 > b1 && b1 + c1 > a1)
    // {
    //     return true;
    // }
    // return false; //иначе false
    return a1 + b1 > c1 && a1 + c1 > b1 && b1 + c1 > a1;
}

bool result = CheckTriangle(a, b, c);
if (result) 
    Console.WriteLine("Три числа являются сторонами треугольника");
else 
    Console.WriteLine("Три числа не являются сторонами треугольника");
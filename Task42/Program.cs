// Задача 42: Напишите программу, которая 
//1. будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());

int ChangeToBin(int a)
{
    // int b = a%2;
    // int c = b/2;   
    int result = 0;
    int mult = 1;
    while (a > 0)
    {
        result += a % 2 * mult;   //тоже что и result = result + a%2
        a /= 2;
        mult *= 10; // тоже что и mult = mult * 10
    }
    return result;
}

int res = ChangeToBin(num);
System.Console.WriteLine($"{res}");
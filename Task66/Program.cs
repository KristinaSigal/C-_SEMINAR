// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое целое число: ");
int firstnumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе положительное число: ");
int secondnumber = Convert.ToInt32(Console.ReadLine());

int SumNumberBetween(int m, int n)
{
    if (m > n)
    {
        int temp = n;
        n = m;
        m = temp;
    }
    if (m < n)
    {
        return m + SumNumberBetween(m + 1, n);
    }
    return m;
}
Console.WriteLine(SumNumberBetween(firstnumber, secondnumber));
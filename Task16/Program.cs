// Задача №16. Напишите программу, которая 
// 1. принимает на вход два числа и 
// 2. проверяет, является ли одно число квадратом другого.
//      5, 25 -> да
//      -4, 16 -> да
//      25, 5 -> да
//      8,9 -> нет

Console.WriteLine("Введите первое целое число.");
int firstnumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число.");
int secondnumber = Convert.ToInt32(Console.ReadLine());

bool Compare(int number1, int number2)
{
    return number1 == number2 * number2 || number2 == number1 * number1;
}

bool result = Compare(firstnumber, secondnumber);
Console.WriteLine(result ? "Да" : "Нет");
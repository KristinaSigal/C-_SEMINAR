// Задача 15: Напишите программу, которая 
//         1. принимает на вход цифру, обозначающую день недели, и 
//         2. проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру от 1 до 7.");
int number = Convert.ToInt32(Console.ReadLine());

bool CheckDay(int num)
{
    return num == 6 || num == 7;
}

bool result = CheckDay(number);
Console.WriteLine(number > 7 || number < 1 ? "Ошибка ввода." : (result ? "Да" : "Нет"));
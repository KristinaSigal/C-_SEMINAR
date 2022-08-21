// 12. Напишите программу, которая 
// * будет принимать на вход два числа
// * выводить, является ли второе числократным первому. 
// * Если число 2 не кратно числу 1, то программа выводит остаток от деления.
//     34, 5 -> не кратно, остаток 4
//     16, 4 -> кратно

Console.WriteLine("Введите первое целое число.");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число.");
int number2 = Convert.ToInt32(Console.ReadLine());

void Multiplicity (int number1, int number2) // метод принимает 2 аргумента
{
    int result = number1 % number2; 
    if (result == 0)
    {
        Console.WriteLine($"Число {number1} кратно числу {number2}");
    }
    else
    {
        Console.WriteLine($"Число {number1} не кратно числу {number2}, остаток => {result}");
    }
}

Multiplicity(number1, number2); //вызов метода
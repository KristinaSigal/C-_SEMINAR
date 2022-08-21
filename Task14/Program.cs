// Задача №14. Напишите программу, которая 
// 1. принимает на вход число 
// 2. проверяет, кратно ли оно одновременно 7 и 23.
//      14 -> нет
//      46 -> нет
//      161 -> да

Console.WriteLine("Введите целое число.");
int number = Convert.ToInt32(Console.ReadLine());

void Multiplicity (int number)
{
    int res1 = number % 7;
    int res2 = number % 23;  
    if (res1 == 0 && res2 == 0)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}

Multiplicity(number); 


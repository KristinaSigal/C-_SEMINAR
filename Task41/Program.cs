// Задача 41: 
// 1. Пользователь вводит с клавиатуры M чисел. 
// 2. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа разделяя их знаком [;]");
string[] arrayString = (Console.ReadLine()).Split(';');

int count = 0;
for(int i = 0; i < arrayString.Length; i++)
{
    if (Convert.ToInt32(arrayString[i]) > 0) 
    count++;
}
Console.WriteLine(count);
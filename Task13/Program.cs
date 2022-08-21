// Задача 13: Напишите программу, которая 
//  * выводит третью цифру заданного числа или 
//  * сообщает, что третьей цифры нет. 
// Решить без использования строк.
//     645 -> 5
//     78 -> третьей цифры нет
//     32679 -> 6

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

void ThirdDigit(int num)
{
    while (num >= 1000)
    {
        num = num / 10;
    }
    Console.WriteLine(num > 99 ? num % 10 : "Третьего числа нет");
}
ThirdDigit(number);
// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти");
int num = Convert.ToInt32(Console.ReadLine());

string Span(int numb)
{
    if (numb == 1) return ("Значение переменных: x > 0 и у > 0");
    if (numb == 2) return ("Значение переменных: x < 0 и у > 0");
    if (numb == 3) return ("Значение переменных: x < 0 и у < 0");
    if (numb == 4) return ("Значение переменных: x > 0 и у < 0");
    return ("Указана некорректная четверть");
}

string result = Span(num);
Console.WriteLine(result);

// Задача 43: Напишите программу, которая 
// найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k2");
double k2 = Convert.ToDouble(Console.ReadLine());

void FindPoint (double bb1, double kk1, double bb2, double kk2)
{
    double x = (bb2-bb1)/(kk1-kk2);
    double y = kk1*x + bb1;
    Console.WriteLine($"Точка пересечения двух прямых ({x.ToString("0.00")};{y.ToString("0.00")})");
}

FindPoint(b1, k1, b2, k2);
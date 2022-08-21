// Задача 20: Напишите программу, которая
// 1. принимает на вход координаты двух точек и
// 2. находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты точки");
Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine()); //ReadLine - возвращает строку, Convert.ToInt32 - конвертирует в число
Console.Write("Y1: ");
int y1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки");
Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double Pifagor (int xc1, int yc1, int xc2, int yc2)
{
    return Math.Sqrt((xc2-xc1)*(xc2-xc1) + (yc2-yc1)*(yc2-yc1));
}

double result = Pifagor(x1, x2, y1, y2);
Console.WriteLine($"Растояние между точками {Math.Round(result, 3)}");
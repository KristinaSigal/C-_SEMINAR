// Задача 68: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

bool mistake = false;
int m;
int n;

do
{
    Console.WriteLine("Введите первое целое положительное число m: ");
    m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе целое положительное число n: ");
    n = Convert.ToInt32(Console.ReadLine()); 
    mistake = n <0 || n>5 || m<0|| m>5 || (n == 1 && m > 4) || (n >1 && m > 3);
    if (mistake) Console.WriteLine("Ошибка ввода, повторите попытку.");
} while (mistake);

void F(int m1, int n1)
{
        int Akkerman(int m1, int n1)
        {
            if (m1 == 0) return n1 + 1;
            if (m1 > 0 && n1 == 0) return Akkerman(m1 - 1, 1);
            if (m1 > 0 && n1 > 0) return Akkerman(m1 - 1, Akkerman(m1, n1 - 1));
            return 0;
        }
    Console.WriteLine(Akkerman(m1, n1));
}

F(m, n);
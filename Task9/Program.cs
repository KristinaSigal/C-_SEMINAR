// 9. Напишите программу, которая 
// 1. выводит случайное число из отрезка [10, 99] и 
// 2. показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8


int number = new Random().Next(10, 100); //получаем псевдослучайное число в диапазоне от 10 до 99 (+1)
Console.WriteLine($"Случайное число из отрезка 10 - 99=> {number}"); //вывод этого числа

// int firstDigit = number / 10; //нахождение первой цифры
// int secondDigit = number % 10; //нахождение второй цифры

// if(firstDigit == secondDigit) Console.WriteLine("Числа равны");
// else
// {
//     //int max = firstDigit;
//     //if (secondDigit > max) max = secondDigit;
//     //int max = firstDigit > secondDigit ? firstDigit : secondDigit; // если fD больше sD, выводим fD, иначе sD (указываем результат сразу с переменную, вместо вышеуказаной конструкции)
//     Console.WriteLine($"Наибольшая цифра числа {number} =>");
//     Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit); //тоже записано сразу в вывод
//     //Console.WriteLine($"Наибольшая цифра числа {number} => {max}");
// }

int MaxDigit(int num)//сигнатура метода
{
    int firstDigit = num / 10; //нахождение первой цифры
    int secondDigit = num % 10; //нахождение второй цифры
    if (firstDigit == secondDigit) return -1;
    return firstDigit > secondDigit ? firstDigit : secondDigit; // возвращает : если fD больше sD, выводим fD, иначе sD
}

int maxDigit = MaxDigit(number);
string result = maxDigit != -1 ? maxDigit.ToString() : "Цифры одинаковые"; //если максдижит не равен -1, тогда выводим максдижит ()переденный в "текст" строку), иначе выводим "Цифры одинаковые"
Console.WriteLine($"Наибольшая цифра числа {number} => {result}");
// 11. Напишите программу, которая 
// * выводит случайное трёхзначное число 
// * удаляет вторую цифру этого числа.
//      456 -> 46
//      782 -> 72
//      918 -> 98

int number = new Random().Next(100, 1000); //получаем псевдослучайное число в диапазоне от 100 до 999 (+1)

int DeletemMidleDigit(int num)//сигнатура метода
{
    int firstDigit = num / 100; //нахождение первой цифры числа
    int secondDigit = num % 10; //нахождение третьей цифры числа
    int result = firstDigit * 10 + secondDigit;
    //int result = num / 100 * 10 + num % 10;
    return result;
}

int res = DeletemMidleDigit(number);
Console.WriteLine($"Сгенерированное трехзначное число => {number}. Обработанное двузначное число => {res}");
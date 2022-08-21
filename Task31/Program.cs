// Задача 31: 
// 1. Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. 
// 2. Найдите сумму отрицательных и положительных элементов массива.
// 3. Вывести результат в консоль.
// 
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна -20.

int[] CreateRndArray(int size, int min, int max)
{
    int[] array = new int[size]; //создание массива
    Random rnd = new Random(); //объект методов Random для работы со случайными числами

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

int[] GetSumPosNegElem(int[] array) //методб кот находит суммы отрицательнх чисел в массиве и сумму положительных значений
{
    int sumNeg = 0;
    int sumPos = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
            sumNeg += array[i];
        else 
            sumPos += array[i];
    }
    return new int[] {sumNeg, sumPos}; // {sumNeg, sumPos} == {0,1}

}

void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length - 1]);
    Console.WriteLine("]");
}

int[] arr = CreateRndArray(12, -9, 10);
PrintArray(arr);
int[] sumPosNegElem = GetSumPosNegElem(arr);
Console.WriteLine();
Console.WriteLine($"Сумма отрицательных чисел равна = {sumPosNegElem[0]}");
Console.WriteLine($"Сумма положительных чисел равна = {sumPosNegElem[1]}");
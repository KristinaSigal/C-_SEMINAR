// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] arr1 = CreateRndArray(5, 0, 10);

int[] resultArr = CalcArr(arr1);
PrintArray(arr1);
PrintArray(resultArr);

int[] CreateRndArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
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

int[] CalcArr(int[] arr)
{
    int count = arr.Length / 2;
    if (arr.Length % 2 != 0) count++;
    
    int[] resArr = new int[count];
    for(int i = 0; i < count; i++)
    {
        resArr[i] = arr1[i] * arr[arr.Length - 1 - i];
    }
    if (arr.Length % 2 != 0) {resArr[resArr.Length - 1] = arr[count - 1];}
    return resArr;
}
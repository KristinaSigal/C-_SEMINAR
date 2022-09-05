// Задача 53: 
// 1. Задайте двумерный массив. 
// 2. Напишите программу,которая поменяет местами 
// первую и последнюю строку массива.

int[,] CreateMatrixRndInt(int row, int col, int min, int max) // row - ряды, col - столбцы(колонки)
{
    int[,] matrix = new int[row, col];//  Lenght = row*coll
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // проход по строкам, можно указать i < row (вместо i < matrix.GetLength(0)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // проход по колонкам, можно указать i < col (вместо i < matrix.GetLength(0)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}

void PrinMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 4}, "); // {matrix[i, j], 4} 4 - форматирование,отступ для выравнивания
            else Console.Write($"{matrix[i, j], 4}"); // {matrix[i, j], 4} 4 - форматирование, отступ для выравнивания
        }
        Console.WriteLine("]");
    }
}

void SwapArray(int[,] matrix)
{
    int firstRow = 0;
    int lastRow = matrix.GetLength(0) - 1;
    int col = matrix.GetLength(1);
    for (int i = 0; i < col; i++)
    {
        int temp = matrix[lastRow, i];
        matrix[lastRow, i] = matrix[firstRow, i];
        matrix[firstRow, i] = temp;
    }
}

int[,] matr = CreateMatrixRndInt(4, 4, 0, 99);
PrinMatrix(matr);
Console.WriteLine();
SwapArray(matr);
PrinMatrix(matr);

// Задача 55: 
// 1. Задайте двумерный массив. 
// 2. Напишите программу, которая заменяет строки на столбцы.
// 3. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] CreateMatrixRndInt(int row, int col, int min, int max) // row - ряды, col - столбцы(колонки)
{
    int[,] matrix = new int[row, col];//  Lenght = row*coll
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // проход по строкам, можно указать i < row (вместо i < matrix.GetLength(0)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // проход по строкам, можно указать i < col (вместо i < matrix.GetLength(0)
        {
            matrix[i, j] = rnd.Next(min,max + 1);
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

int[,] TurnArray(int[,] matrix)
{
    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);
    int[,] turnMatr = new int[row, col];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            turnMatr[i,j] = matrix[j,i];
        }
    }
    return turnMatr;
}

int[,] matr= CreateMatrixRndInt(4,4,10,99);
PrinMatrix(matr);
Console.WriteLine();
int[,] turnMatr = TurnArray(matr);
PrinMatrix(turnMatr);

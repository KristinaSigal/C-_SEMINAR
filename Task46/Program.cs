// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int[,] CreateMatrixRndInt(int row, int col, int min, int max) // row - ряды, col - столбцы(колонки)
{
    int[,] matrix = new int[row, col];//  Lenght = row*coll
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // проход по строкам, можно указать i < row (вместо i < matrix.GetLength(0)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // проход по строкам, можно указать i < col (вместо i < matrix.GetLength(0)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
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

int[,] matrix = CreateMatrixRndInt(3, 4, -99, 99);
PrinMatrix(matrix);
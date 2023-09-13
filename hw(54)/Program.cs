// Задача 54: Задайте двумерный массив.
// Напишите программу, которая упорядачит по убыванию элементы каждой строки двумерного массива

// Например массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// На выходе:

// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine();
    }
}

void DecreasingElemEachRows(int[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            for (int k = 0; k < array2d.GetLength(1) - 1; k++)
            {
                if (array2d[i, k] < array2d[i, k + 1])
                {
                    int temp = array2d[i, k + 1];
                    array2d[i, k + 1] = array2d[i, k];
                    array2d[i, k] = temp;
                }

            }
        }
    }
}

int[,] array2d = CreateMatrixRndInt(4, 5, 1, 10);
PrintMatrix(array2d);
Console.WriteLine();
DecreasingElemEachRows(array2d);
PrintMatrix(array2d);
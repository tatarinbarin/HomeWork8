// Задача 58: Задайте 2 матрицы.
// Напишите программу, которая будет находить произведение двух матриц.

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

void MultTwoMatrix(int[,] matrixA, int[,] matrixB, int[,] multMatrix)
{
    for (int i = 0; i < multMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < multMatrix.GetLength(1); j++)
        {
            int sumElem = 0;
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                sumElem += matrixA[i, k] * matrixB[k, j];
            }
            multMatrix[i, j] = sumElem;
        }
    }
}

int[,] matrixA = CreateMatrixRndInt(2, 2, 1, 10);
Console.WriteLine("1-ая матрица:");
Console.WriteLine();
PrintMatrix(matrixA);
Console.WriteLine();
int[,] matrixB = CreateMatrixRndInt(2, 2, 1, 10);
Console.WriteLine("2-ая матрица:");
Console.WriteLine();
PrintMatrix(matrixB);
Console.WriteLine();
int[,] multMatrix = new int[2, 2];
Console.WriteLine("Произведение двух матриц:");
Console.WriteLine();
MultTwoMatrix(matrixA,matrixB,multMatrix);
PrintMatrix(multMatrix);
Console.WriteLine();

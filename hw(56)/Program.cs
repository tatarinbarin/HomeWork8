// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшой суммой элементов.

// Массив:

//   1  4  7  2
//   5  9  2  3 
//   8  4  2  4
//   5  2  6  7

// Программа считает сумму элементов в каждой строке 
//и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int MinSumElemRows(int[,] matrix)
{
    Console.Write("Сумма элементов каждой строки -> ");
    int minSumElem = 0;
    int sumRows = SumElemRows(matrix, 0);

    int SumElemRows(int[,] matrix, int i)
    {
        int sumRows = matrix[i, 0];
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            sumRows += matrix[i, j];
        }
        Console.Write($"{sumRows}  ");
        return sumRows;
    }
    
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int tempSumElemRows = SumElemRows(matrix, i);
        if (sumRows > tempSumElemRows)
        {
            sumRows = tempSumElemRows;
            minSumElem = i;
        }
    }
    return minSumElem;
}

Console.WriteLine();
int[,] arr2d = CreateMatrixRndInt(4, 6, 1, 20);
PrintMatrix(arr2d);
Console.WriteLine();
int minSumElemRows = MinSumElemRows(arr2d);
Console.WriteLine();
Console.WriteLine($"Строка под № {minSumElemRows + 1} содержит наименьшую сумму элементов");
Console.WriteLine();





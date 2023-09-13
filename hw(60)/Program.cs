// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.

int[,,] CreateArr3dRndInt (int rows, int columns, int depth, int min, int max)
{
  int[,,] arr3d = new int[rows, columns, depth];
  for (int i = 0; i < arr3d.GetLength(0); i++)
  {
    for (int j = 0; j < arr3d.GetLength(1); j++)
    {
      for (int k = 0; k < arr3d.GetLength(2); k++)
      {
        arr3d[i,j,k] = min++;
      }
    }
  }
  return arr3d;
}

void PrintArr3dToStringIndexes (int[,,] arr3d)
{
  Console.WriteLine("Трёхмерный массив размером 2 х 2 х 2");
  Console.WriteLine("Из неповторяющихся двузначных чисел, с добавлением индексов каждого элемента");
  Console.WriteLine();
  for (int i = 0; i < arr3d.GetLength(0); i++)
  {
    for (int j = 0; j < arr3d.GetLength(1); j++)
    {
      for (int k = 0; k < arr3d.GetLength(2); k++)
      {
        Console.Write($" {arr3d[i,j,k] }({i},{j},{k})");
      }
    }
    Console.WriteLine();
  }
}

int[,,] array3d = CreateArr3dRndInt(2,2,2,10,99);
PrintArr3dToStringIndexes(array3d);
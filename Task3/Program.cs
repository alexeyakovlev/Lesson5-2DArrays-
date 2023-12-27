//Задайте прямоугольный двумерный массив.
//Напишите программу, которая будет находить
//строку с наименьшей суммой элементов.

Console.Clear();

int[,] Array(int rows, int steps)
{
  int[,] array = new int[rows, steps];
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < steps; j++)
    {
      array[i, j] = new Random().Next(10);
    }
  }
  return array;
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
  Console.WriteLine();
}

int MinSum(int[,] array)
{
  int min = 100;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
      sum = sum + array[i, j];
    }
    if (sum < min) min = sum;
  }
  return min;
}

int MinRow(int[,] array)
{
  int minRow = 0;
  int min = 100;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
      sum = sum + array[i, j];
    }
    if (sum < min) { min = sum; minRow = i;}
  }
  return minRow;
}

int[,] array = Array(5, 5);
PrintArray(array);
Console.WriteLine("Минимальная сумма у строки " + MinRow(array) + " равная " + MinSum(array));
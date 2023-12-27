//Напишите программу, которая на вход
//принимает позиции элемента в двумерном массиве, и
//возвращает значение этого элемента или же указание,
//что такого элемента нет.

Console.Clear();

int ReadInt(string msg)
{
  Console.Write(msg);
  return Convert.ToInt32(Console.ReadLine());
}

int[,] Array(int rows, int steps)
{
  int[,] array = new int [rows, steps];
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
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
  Console.WriteLine();
}


int i = ReadInt("Введите номер строки: ");
int j = ReadInt("Введите номер столбца: ");
int[,] array = Array(5,5);
PrintArray(array);

if (i < array.GetLength(0) && j < array.GetLength(1)) 
{
  Console.WriteLine(array[i, j]);
}
else 
{
  Console.WriteLine($"{i}{j}: такого числа в массиве нет");
}
// Задача 58: Задайте два двумерных массива (от 0 до 10). Напишите программу, которая будет находить
// произведение двух массивов (поэлементное).
// Например, даны 2 массива:
// 2 4
// 3 2

// 3 4
// 3 3

// Результирующая матрица будет:
// 6 16
// 9 6

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 11);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int N = ReadInt("Введите количество строк: ");
int M = ReadInt("Введите количество столбцов: ");
int[,] array1 = new int[N, M];
int[,] array2 = new int[N, M];
int[,] array3 = new int[N, M];

FillArray(array1);
PrintArray(array1);
Console.WriteLine();
FillArray(array2);
PrintArray(array2);
Console.WriteLine();

for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        array3[i, j] = 0;
        array3[i, j] += array1[i, j] * array2[i, j];
    }
}

PrintArray(array3);

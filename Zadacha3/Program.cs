// Задайте две матрицы. Напишите программу, которая будет находить  их произведение.

int m = ReadInt("Введите количество строк матрицы А: ");
int n = ReadInt("Введите количество столбцов матрицы А: ");
int[,] matrixA = new int[m, n];

FillMatrixRandomNumbers(matrixA);
WriteMatrix(matrixA);

Console.WriteLine();

int c = ReadInt("Введите количество строк матрицы Б: ");
int d = ReadInt("Введите количество столбцов матрицы Б: ");
int[,] matrixB = new int[c, d];

FillMatrixRandomNumbers(matrixB);
WriteMatrix(matrixB);

Console.WriteLine();

if (matrixA.GetLength(1) != matrixB.GetLength(0))
{
    Console.WriteLine("Умножение невозможно");
    return;
}

int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

for (int i = 0; i < matrixA.GetLength(0); i++)
{
    for (int j = 0; j < matrixB.GetLength(1); j++)
    {
        matrixC[i, j] = 0;
        for (int k = 0; k < matrixA.GetLength(1); k++)
        {
            matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
        }
    }
}
WriteMatrix(matrixC);



void FillMatrixRandomNumbers(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1,10);
        }
    }
}

void WriteMatrix(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
    Console.WriteLine();
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива

int m = ReadInt("Введите количество строк массива: ");
int n = ReadInt("Введите количество столбцов массива: ");
int[,] numbers = new int[m, n];

FillMatrixRandomNumbers(numbers);
WriteMatrix(numbers);
Console.WriteLine();
SortString(numbers);
WriteMatrix(numbers);


void SortString (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int a = 0; a < array.GetLength(1); a++)
            {
                if(array[i,j] <= array[i, a]) continue;
                int temp = array[i, j];
                array[i, j] = array[i, a];
                array[i, a] = temp;
            }
        }
    }
}


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

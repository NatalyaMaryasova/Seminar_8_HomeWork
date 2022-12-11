// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить
// строку с наименьшей суммой элементов

int m = 5;
int n = 5;
int[,] numbers = new int[m, n];

FillMatrixRandomNumbers(numbers);
WriteMatrix(numbers);

int sum = int.MaxValue;
int index = 0;
for (int i = 0; i < m; i++)
{
    int temp = 0;
    for (int j = 0; j < n; j++)
    {
        temp += numbers[i, j];
    }
    if (temp < sum)
    {
        sum = temp;
        index = i;
    }
}
Console.WriteLine();
Console.WriteLine(index + " " + "строка с наименьшей суммой");


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


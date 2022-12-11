// Сфрмируйте трехмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы элементов

int a = 2;
int b = 2;
int c = 2;
int[,,] numbers = new int[a, b, c];

int[] nums = new int[90];
a = 0;
for(int i = 0; i < nums.Length; i++)
{
    nums[i] = 10 + a;
    a++;
}

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        for (int k = 0; k < numbers.GetLength(2); k++)
        {
            numbers[i, j, k] = nums[new Random(). Next(0, 90)];
        }
    }
}


PrintMatrix(numbers);

void PrintMatrix(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k})");
            }
            Console.WriteLine();
        }
    }
}

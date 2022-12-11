// Напишите программу, которая спирально заполнит массив 4*4

int m = 4;
int[,] numbers = new int[m, m];

int count = 1;

 for(int j = 0; j < m; j++)
 {
    numbers[0, j] = count;
    count++;
 }
 for (int i = 1; i < m; i++)
 {
    numbers[i, m-1] = count;
    count++;
 }
 for(int j = m - 2; j >= 0; j--)
 {
    numbers[m - 1, j] = count;
    count++;
 }
 for (int i = m - 2; i > 0; i--)
 {
    numbers[i, 0] = count;
    count++;
 }

 int c = 1;
 int d = 1;

 while (count < m*m)
 {
    while (numbers[c, d+1] == 0)
    {
        numbers[c, d] = count;
        count++;
        d++;
    }
    while (numbers[c+1, d] == 0)
    {
        numbers[c, d] = count;
        count++;
        c++;
    }
    while (numbers[c, d-1] == 0)
    {
        numbers[c, d] = count;
        count++;
        d--;
    }
    while (numbers[c-1, d] == 0)
    {
        numbers[c, d] = count;
        count++;
        c--;
    }
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
        {
            if (numbers[i, j] == 0)
            {
                numbers[i, j] = count;
            }
        }
    }
 }

            
WriteMatrix(numbers);

void WriteMatrix(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if (numbers[i, j] < 10)
            {
                Console.Write("0" + array[i, j] + " ");
            }
            else
            Console.Write(array[i, j] + " ");
        }
    Console.WriteLine();
    }
}
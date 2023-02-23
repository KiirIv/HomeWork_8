/* Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int[,] array = new int[4, 4];

void FillArray(int[,] arr)
{
    int n = 4;
    int i = 0; 
    int j = 0;
    int size = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { arr[i, j++] = size++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) arr[i++, j] = size++;
        for (k = 0; k < n - 1; k++) arr[i, j--] = size++;
        for (k = 0; k < n - 1; k++) arr[i--, j] = size++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + arr[i, j]);
                Console.Write(" ");
            }
            else Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

FillArray(array);
PrintArray(array);
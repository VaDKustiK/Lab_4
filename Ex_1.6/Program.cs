using System;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

int[] array = new int[4];
int[,] A = new int[4, 7];
Console.WriteLine("Введите значения матрицы");
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 7; j++)
    {
        A[i, j] = int.Parse(Console.ReadLine());
    }
}

for (int i = 0; i < 4; i++)
{
    int min1 = int.MaxValue;
    for (int j = 0; j < 7; j++)
    {
        if (A[i, j] < min1)
        {
            min1 = A[i, j];
            array[i] = j;
        }
    }
}
Console.WriteLine(string.Join(", ", array));
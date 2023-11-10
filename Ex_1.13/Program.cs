using System;
using System.Diagnostics.Metrics;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

int n = 5, m = 5;
int[,] A = new int[n, m];

Console.WriteLine("Введите значения матрицы");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        A[i, j] = int.Parse(Console.ReadLine());
    }
}

int J = 0;
int max1 = int.MinValue;
for (int i = 0; i < n; i++)
{
    int j = i;
    if (A[i, j] > max1)
    {
        max1 = A[i, j];
        J = j;
    }
}

int temp = 0;
for (int i = 0; i < n; i++)
{
    temp = A[i, J];
    A[i, J] = A[i, 3];
    A[i, 3] = temp;
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(A[i, j] + " ");
    }
    Console.WriteLine();
}
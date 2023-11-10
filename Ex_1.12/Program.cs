using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

int n = 3, m = 3;
int[,] A = new int[n, m];

Console.WriteLine("Введите значения матрицы");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        A[i, j] = int.Parse(Console.ReadLine());
    }
}

int I = 0;
int J = 0;
int max1 = int.MinValue;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (A[i, j] > max1)
        {
            max1 = A[i, j];
            I = i;
            J = j;
        }
    }
}
Console.WriteLine($"max1 = {max1}");
Console.WriteLine($"I = {I}, J = {J}");

n--;
for (int i = I; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        A[i, j] = A[i+1, j];
    }
    Console.WriteLine();
}
m--;
for (int i = 0; i < n; i++)
{
    for (int j = J; j < m; j++)
    {
        A[i, j] = A[i, j+1];
    }
    Console.WriteLine();
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(A[i, j] + " ");
    }
    Console.WriteLine();
}
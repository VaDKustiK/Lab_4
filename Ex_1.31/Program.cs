using System;
using System.Runtime.Serialization.Formatters;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

int n = 5, m = 8;
int[,] A = new int[n, m];
Random r = new Random();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        A[i, j] = r.Next(55);
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m-1; j++)
    {
        Console.Write(A[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int[] b = new int[5] {999,999,999,999,999};

int J = 0;
int min5 = 99;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (A[i, j] < min5 && i == 4)
        {
            min5 = A[i, j];
            J = j;
        }
    }
}

for (int i = 0; i != 5; i++)
{
    for (int j = 7 - 1; j != J; j--)
    {
        A[i, j + 1] = A[i, j];
    }
}
for (int i = 0; i != 5; i++)
{
    A[i, J + 1] = b[i];
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(A[i, j] + " ");
    }
    Console.WriteLine();
}
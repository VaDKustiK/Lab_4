using System;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

int n = 6, m = 7;
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
    for (int j = 0; j < m; j++)
    {
        Console.Write(A[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int temp = 0;
for (int i = 0; i < n; i++)
{
    int t = 0;
    for (int j = m-1; j >= 3; j--)
    {
        temp = A[i, j];
        A[i, j] = A[i, t];
        A[i, t] = temp;
        t++;
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(A[i, j] + " ");
    }
    Console.WriteLine();
}
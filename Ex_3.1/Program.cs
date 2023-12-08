using System;
using System.Numerics;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

int n = 7, m = 5;

int[,] A = new int[n, m];
Random r = new Random();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        A[i, j] = r.Next(10, 50);
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

int[] ind = new int[n];
int[] s = new int[n];
for (int i = 0; i < n; i++)
{
    int mini = A[i, 0];
    for (int j = 0; j < m; j++)
    {
        if (A[i, j] < mini)
        {
            mini = A[i, j];
        }
    }
    ind[i] = i;
    s[i] = mini;
}
for (int i = 0; i < n-1; i++)
{
    int maxi = s[i];
    int maxind = i;
    for (int j = i + 1; j < 7; j++)
    {
        if (s[j] > maxi)
        {
            maxi = s[j];
            maxind = j;
        }
    }
    s[maxind] = s[i];
    s[i] = maxi;
    int temp = ind[maxind];
    ind[maxind] = ind[i];
    ind[i] = temp;
}

for (int i = 0; i < n; i++)
{
    int temp = ind[i];
    for (int j = 0; j < m; j++)
    {
        Console.Write(A[temp, j] + " ");
    }
    Console.WriteLine();
}
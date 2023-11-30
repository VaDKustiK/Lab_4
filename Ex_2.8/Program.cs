using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

int n = 6;
int[,] B = new int[n, n];
Random r = new Random();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        B[i, j] = r.Next(55);
    }
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(B[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < n; i += 2)
{
    int max1 = -1;
    int i1 = i, j1 = 0;
    int max2 = -1;
    int i2 = i + 1, j2 = 0;
    for (int j = 0; j < n; j++)
    {
        if (B[i, j] > max1)
        {
            max1 = B[i, j];
            j1 = j;
        }
        if (i+1 < n && B[i+1, j] > max2)
        {
            max2 = B[i+1, j];
            j2 = j;
        }
    }
    int temp = B[i1, j1];
    B[i1, j1] = B[i2, j2];
    B[i2, j2] = temp;
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(B[i, j] + " ");
    }
    Console.WriteLine();
}
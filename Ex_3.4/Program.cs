using System;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Введите значение N");
int n = int.Parse(Console.ReadLine());
int[,] A = new int[n, n];
Random r = new Random();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        A[i, j] = r.Next(9);
    }
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(A[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i >= n/2 && j <= i)
            A[i, j] = 1;
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(A[i, j] + " ");
    }
    Console.WriteLine();
}
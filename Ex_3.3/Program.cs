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
        A[i, j] = r.Next(10);
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

int[] b = new int[2*n - 1];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        int ind = j - i + n - 1;
        b[ind] += A[i, j];
    }
}

Console.WriteLine("[{0}]", string.Join(", ", b));
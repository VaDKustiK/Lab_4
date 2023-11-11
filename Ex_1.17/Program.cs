using System;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Введите значение n");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение m");
int m = int.Parse(Console.ReadLine());

int[,] B = new int[n, m];

Console.WriteLine("Введите значения матрицы");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        B[i, j] = int.Parse(Console.ReadLine());
    }
}

for (int i = 0; i < n; i++)
{
    int mini = 0;
    int minelem = B[i, mini];
    for (int j = 1; j < m; j++)
    {
        if (B[i, j] < minelem)
        {
            mini = j;
            minelem = B[i, mini];
        }
    }
    for (int k = mini; k > 0; k--)
    {
        int temp = B[i, k];
        B[i, k] = B[i, k - 1];
        B[i, k - 1] = temp;
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(B[i, j] + " ");
    }
    Console.WriteLine();
}
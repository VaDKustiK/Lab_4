using System;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

int n = 4, m = 4; // n = 5, m = 7
int[,] F = new int[n, m];

Console.WriteLine("Введите значения матрицы");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        F[i, j] = int.Parse(Console.ReadLine());
    }
}


int J = 0;
int min2 = int.MaxValue;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (Math.Abs(F[i, j]) < min2 && i == 1)
        {
            min2 = Math.Abs(F[i, j]);
            J = j;
        }
    }
}

m--;
for (int i = 0; i < n; i++)
{
    for (int j = J+1; j < m; j++)
    {
        F[i, j] = F[i, j + 1];
    }
    Console.WriteLine();
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(F[i, j] + " ");
    }
    Console.WriteLine();
}
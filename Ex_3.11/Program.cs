using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Введите количество строк");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int m = int.Parse(Console.ReadLine());

int[,] A = new int[n, m];

Random r = new Random();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        A[i, j] = r.Next(0, 10);
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
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (i == 0)
        {
            if (A[0, j] == 0)
            {
                ind[0] = 1;
                break;
            }
        }
        else if (A[i, j] == 0 & i != 0)
        {
            ind[i] = i;
            break;
        }
    }
}

for (int i = 0; i < n; i++)
{
    if (ind[i] == 0)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write(A[i, j] + " ");
        }
        Console.WriteLine();
    }
}
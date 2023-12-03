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

int count = 0;
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
                count++;
                break;
            }
        }
        else if (A[i, j] == 0 & i != 0)
        {
            ind[i] = i;
            count++;
            break;
        }
    }
}

Console.WriteLine("[{0}]", string.Join(", ", ind));

int ncount = n - count;
for (int i = 0; i < ncount; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (ind[i] == 0)
            Console.Write(A[i, j] + " ");
        else
            ncount++;
    }
    Console.WriteLine();
}
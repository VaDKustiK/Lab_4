using System;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Введите количество строк:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int m = int.Parse(Console.ReadLine());
int[,] A = new int[n, m];

Random r = new Random();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        A[i, j] = r.Next(-9, 10);
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

int[] chet = new int[n * (m / 2)];
int[] nechet = new int[n * ((m + 1) / 2)];
int chet_ind = 0;
int nechet_ind = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (j % 2 == 0)
        {
            chet[chet_ind++] = A[i, j];
        }
        else
        {
            nechet[nechet_ind++] = A[i, j];
        }
    }

    // chet
    for (int k = 0; k < chet_ind - 1; k++)
    {
        for (int l = 0; l < chet_ind - k - 1; l++)
        {
            if (chet[l] < chet[l + 1])
            {
                int temp = chet[l];
                chet[l] = chet[l + 1];
                chet[l + 1] = temp;
            }
        }
    }

    // nechet
    for (int k = 0; k < nechet_ind - 1; k++)
    {
        for (int l = 0; l < nechet_ind - k - 1; l++)
        {
            if (nechet[l] > nechet[l + 1])
            {
                int temp = nechet[l];
                nechet[l] = nechet[l + 1];
                nechet[l + 1] = temp;
            }
        }
    }

    for (int j = 0; j < m; j++)
    {
        if (j % 2 == 0)
        {
            A[i, j] = chet[--chet_ind];
        }
        else
        {
            A[i, j] = nechet[--nechet_ind];
        }
    }
    chet_ind = 0;
    nechet_ind = 0;
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(A[i, j] + " ");
    }
    Console.WriteLine();
}
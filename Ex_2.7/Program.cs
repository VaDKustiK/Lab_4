using System;
using System.Text;
using System.Xml.Schema;

Console.OutputEncoding = Encoding.UTF8;

int[,] A = new int[6, 6];
Console.WriteLine("Введите значения матрицы");
for (int i = 0; i < 6; i++)
{
    for (int j = 0; j < 6; j++)
    {
        A[i, j] = int.Parse(Console.ReadLine());
    }
}

int I = 0, J = 0;
int maxi = A[0, 0];
for (int i = 0; i < 6; i++)
{
    for (int j = i; j < 6; j++)
    {
        if (A[i, j] > maxi)
        {
            maxi = A[i, j];
            I = i;
            J = j;
        }
    }
}
Console.WriteLine($"maxi = {maxi}");

for (int i = 0; i < 6; i++)
{
    for (int j = 0; j < 6; j++)
    {
        if (i < j && i < I)
            A[i, j] = 0;
    }
}

for (int i = 0; i < 6; i++)
{
    for (int j = 0; j < 6; j++)
    {
        Console.Write(A[i, j] + " ");
    }
    Console.WriteLine();
}
using System;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

int[,] matrix = new int[4, 4];
int n = 4;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = int.Parse(Console.ReadLine());
    }
}
int res = 0;
for (int i = 0; i < n; i++)
{
    int j = i;
    res += matrix[i, j];
}
Console.WriteLine(res);
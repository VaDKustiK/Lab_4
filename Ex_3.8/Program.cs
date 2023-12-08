int n = 7, m = 5;
int[,] A = new int[n, m];
Random r = new Random();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        A[i, j] = r.Next(-10, 10);
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

int[] s = new int[n];
int[] ind = new int[n];
for (int i = 0; i < n; i++)
{
    int count = 0;
    for (int j = 0; j < m; j++)
    {
        if (A[i, j] >= 0)
        {
            count++;
        }
    }
    s[i] = count;
    ind[i] = i;
}
for (int i = 0; i < n-1; i++)
{
    int maxi = s[i];
    int maxind = i;
    for (int j = i + 1; j < 7; j++)
    {
        if (s[j] > maxi)
        {
            maxi = s[j];
            maxind = j;
        }
    }
    s[maxind] = s[i];
    s[i] = maxi;
    int temp = ind[maxind];
    ind[maxind] = ind[i];
    ind[i] = temp;
}

for (int i = 0; i < n; i++)
{
    int temp = ind[i];
    for (int j = 0; j < m; j++)
    {
        Console.Write(A[temp, j] + " ");
    }
    Console.WriteLine();
}
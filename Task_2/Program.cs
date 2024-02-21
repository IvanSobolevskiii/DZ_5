int AkkermanFunc(int n, int m)
{
    if (n == 0)
    {
        return m++;
    }
    else if (m == 0)
    {
        return AkkermanFunc(n - 1, 1);
    }
    return AkkermanFunc(n - 1, AkkermanFunc(n, m - 1));
}

Console.WriteLine(AkkermanFunc(3, 2));
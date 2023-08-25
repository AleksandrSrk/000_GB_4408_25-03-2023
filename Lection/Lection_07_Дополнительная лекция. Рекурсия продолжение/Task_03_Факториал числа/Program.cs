// Факториал числа. Это произведение чисел от 1 до n

int FaktorialFor(int n)
{
    int res = 1;
    for (int i = 1; i <= n; i++)
    {
        res *= i;
    }
    return res;
}

int FaktorialRec(int n)
{
    if (n == 1)
    {
        return 1;
    }
    else return n * FaktorialRec(n - 1);
}
System.Console.WriteLine(FaktorialFor(10));
System.Console.WriteLine(FaktorialRec(10));
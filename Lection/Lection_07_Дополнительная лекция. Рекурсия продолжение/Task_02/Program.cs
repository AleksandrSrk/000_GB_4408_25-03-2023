// Сумма чисел от 1 до n

int SumFor(int n) // обычным методом
{
    int res = 0;
    for (int i = 0; i <= n; i++)
    {
        res += i;
    }
    return res;
}

int SumRec(int n){ // метоодом рекурсии
    if (n==0)
    {
        return 0;
    } else return n + SumRec(n-1);
}

System.Console.WriteLine(SumFor(10));
System.Console.WriteLine(SumRec(10));
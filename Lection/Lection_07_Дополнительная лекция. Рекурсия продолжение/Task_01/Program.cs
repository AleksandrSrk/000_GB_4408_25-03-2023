// Собрать строку с числами от А до Б, а<=b

string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbresRec(int a, int b)
{
    if (a <= b)
    {
        return ($"{a} ") + NumbresRec(a + 1, b);
    }
    else return String.Empty;
}

System.Console.WriteLine(NumbersFor(1, 10));
System.Console.WriteLine(NumbresRec(1, 10));
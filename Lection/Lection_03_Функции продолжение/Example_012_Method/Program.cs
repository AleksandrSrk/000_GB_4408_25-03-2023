// 1) _____ МЕТОД НИЧЕГО НЕ ПРИНИМАЕТ И НИЧЕГО НЕ ВОЗВРАЩАЕТ
System.Console.WriteLine("1) _____ МЕТОД НИЧЕГО НЕ ПРИНИМАЕТ И НИЧЕГО НЕ ВОЗВРАЩАЕТ");

void Method1()
{
    System.Console.WriteLine("Автор .....");
}

// Вызов метода:
Method1();

// 2) _____ МЕТОД ПРИНИМАЕТ НО НИЧЕГО НЕ ВОЗВРАЩАЕТ
System.Console.WriteLine("2) _____ МЕТОД ПРИНИМАЕТ НО НИЧЕГО НЕ ВОЗВРАЩАЕТ");

void Method2(string msg)
{
    System.Console.WriteLine(msg);
}

// Вызов метода:
Method2("Текст сообщения");


// 2.1) _____Пример нескольких аргументов:

System.Console.WriteLine("Пример метода 2 - несколько аргументов:");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(msg);
        i++;
    }
}

// Вызов метода:
Method21("Текст сообщения", 4);
System.Console.WriteLine();
Method21(msg: "Текст сообщения", count: 4); // Передаем оргументы конкретным переменным в методе
System.Console.WriteLine();
Method21(count: 4, msg: "Текст сообщения");

// 3) _____ МЕТОД ВОЗВРАЩАЕТ НО НИЧЕГО НЕ ПРИНИМАЕТ
System.Console.WriteLine("3) _____ МЕТОД ВОЗВРАЩАЕТ НО НИЧЕГО НЕ ПРИНИМАЕТ");

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
System.Console.WriteLine(year);

// 4) _____ МЕТОД ВОЗВРАЩАЕТ И ПРИНИМАЕТ
System.Console.WriteLine("4) _____ МЕТОД ВОЗВРАЩАЕТ И ПРИНИМАЕТ");

string Method4(int count, string text)
{
    int i = 0;
    string res = String.Empty;
    while (i < count)
    {
        res = res + text;
        i++;
    }
    return res;
}

string result = Method4(5, "werty|");
System.Console.WriteLine(result);

// 4.1) _____ МЕТОД ВОЗВРАЩАЕТ И ПРИНИМАЕТ ЧЕРЕЗ ФОР
System.Console.WriteLine("4.1) _____ МЕТОД ВОЗВРАЩАЕТ И ПРИНИМАЕТ");

string Method41(int count, string text)
{
    string res = String.Empty;
    for (int i = 0; i < count; i++)
    {
        res = res + text;
    }
    return res;
}

string result1 = Method41(5, "1werty|");
System.Console.WriteLine(result1);

// 4.2) _____ ВЫВОД ТАБЛИЦЫ УМНОЖЕНИЯ НА ЭКРАН
System.Console.WriteLine("4.2) _____ ВЫВОД ТАБЛИЦЫ УМНОЖЕНИЯ НА ЭКРАН");

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        System.Console.WriteLine($"{i} * {j} = {i*j}");
    }
    System.Console.WriteLine();
}
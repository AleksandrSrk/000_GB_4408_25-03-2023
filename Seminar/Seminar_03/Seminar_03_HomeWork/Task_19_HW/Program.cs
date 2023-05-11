// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
System.Console.Write("Введите целое пятизначное число: ");

try
{
    int num = Convert.ToInt32(Console.ReadLine());
    СheckingForPalindrom(num);

    int Lenght(int numLen)
    {
        string res = Convert.ToString(numLen);
        int count = 0;
        for (int i = 0; i < res.Length; i++)
        {
            count++;
        }
        return count;
    }

    void СheckingForPalindrom(int number)
    {
        if (Lenght(num) == 5)
        {
            int right = number % 100;
            int left = number / 1000;
            if (((right - left) % 9 == 0) && (right - left) != 0)
            {
                System.Console.WriteLine($"ДА! Число {num} является палиндромом");
            }
            else System.Console.WriteLine($"НЕТ! Число {num} не является палиндромом");
        }
        else System.Console.WriteLine("ОШИБКА!!! Нужно ввести пятизначное число");

    }
}

catch
{
    System.Console.WriteLine("ОШИБКА!!! Нужно ввести целое пятизначное число");
}


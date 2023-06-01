// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int Summa(int num)
{
    int res = 0;
    for (int i = 1; i <= num; i++)
    {
        res += i;
    }
    return res;
}



try
{
    System.Console.WriteLine("Введите натуральное число");
    int num = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine($"Сумма всех чисел от 1 до {num} = {Summa(num)}");
}
catch
{

    System.Console.WriteLine("Ошибка! Надо вводить именно целое число!!!");
}


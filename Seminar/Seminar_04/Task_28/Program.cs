// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120



int Multiple(int number)
{
    int mul = 1;
    for (int i = 1; i <= number; i++)
    {
        mul = mul * i;
    }
    return mul;
}

try
{
    System.Console.Write("Введите натуральное число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine($"Произведение чисел от 1 до {num} = {Multiple(num)}");
}
catch
{

    System.Console.WriteLine("!!! ОШИБКА Нужно ввести натуральное число!");
}
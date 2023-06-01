// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.Write("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумма чисел в {num} равна: {SumNumber(num)}");

int SumNumber (int number)
{
    int sum = 0;
    while (number != 0)
    {
        sum  =sum + number%10;
        number = number/10;
    }
    return sum;
}
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите число от 1 до 7");
int num = DayWeek(Convert.ToInt32(Console.ReadLine()));

int DayWeek(int day)
{
    if (day > 0 && day < 6)
        System.Console.WriteLine("нет");
    else if (day > 5 && day < 8)
        System.Console.WriteLine("да");
    else
        System.Console.WriteLine("ОШИБКА!!! Нужно ввести число от 1 до 7");
    return 1;
}
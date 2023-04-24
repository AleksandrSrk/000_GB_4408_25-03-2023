// Напишите программу которая на вход принимает число и выдает его квадрат

/*
System.Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()); // команда предобразовала считываемую строку в целочисленное значение
System.Console.WriteLine(number*number);
*/

// РЕШЕНИЕ ПРЕПОДАВАТЕЛЯ

/*
System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); // Конвертировали строку в число
System.Console.WriteLine(number * number);

if (number > 0)
{
    System.Console.WriteLine("Было введено положительное число");
}
else if (number == 0)
{
    System.Console.WriteLine("Был введен ноль");
}
else System.Console.WriteLine("Было введено отрицательное число");
*/

// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

/*
System.Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2*number2 == number1)
{
    System.Console.WriteLine("да");
}
else System.Console.WriteLine("нет");
*/

// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница


/*
System.Console.Write("Введите номер дня недели от 1 до 7: ");
int numberWeek = Convert.ToInt32(Console.ReadLine());
switch (numberWeek)
{
    case 1:
        System.Console.WriteLine("Понедельник");
        break;
    case 2:
        System.Console.WriteLine("Вторник");
        break;
    case 3:
        System.Console.WriteLine("Среда");
        break;
    case 4:
        System.Console.WriteLine("Четверг");
        break;
    case 5:
        System.Console.WriteLine("Пятница");
        break;
    case 6:
        System.Console.WriteLine("Суббота");
        break;
    case 7:
        System.Console.WriteLine("Воскресенье");
        break;
    default:
        System.Console.WriteLine("ОШИБКА!!! Введите номер дня недели от 1 до 7: ");
        break;

}
*/

// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"


/*
System.Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    int numberMin = number * -1;
    for (int i = numberMin; i <= number; i++)
    {
        System.Console.Write(i + " ");

    }
} else if (number < 0)
{
    int numberMax = number * -1;
    for (int i = numberMax; i >= number; i--)
    {
        System.Console.Write(i + " ");

    }
}
else System.Console.WriteLine("0");
*/

// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

/*
System.Console.Write("Введите целое трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    System.Console.WriteLine(number % 10);
}
else System.Console.Write("ОШИБКА!!! Введите целое трехзначное число: ");
*/

// Теперь на входе целое число любой разрядности, надо вывести третью справа цифру

/*
System.Console.Write("Введите целое число больше 99 или меньше -99: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
    System.Console.WriteLine((number /100) % 10);
}
else if (number < -99)
{
    System.Console.WriteLine((number /100) % 10);
}
else System.Console.Write("ОШИБКА!!! Введите целое число больше 99 или меньше -99: ");
*/

// Теперь на входе целое число любой разрядности, надо вывести третью слева цифру

System.Console.Write("Введите целое число больше 99 или меньше -99: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
    while (number > 999) {
        number = number / 10;
    }
    
    System.Console.WriteLine(number%10);
}
else if (number < -99)
{
    while (number < -999) {
        number = number / 10;
    }
    
    System.Console.WriteLine(number%10);
}
else System.Console.Write("ОШИБКА!!! Введите целое число больше 99 или меньше -99: ");
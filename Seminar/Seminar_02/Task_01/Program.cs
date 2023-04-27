// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

int num = new Random().Next(10, 100);
System.Console.WriteLine($"Было сгенерировано число {num}"); // ФОРМАТИРОВАННЫЙ ВЫВОД
int a = num / 10;
int b = num % 10;
if (a > b)
    System.Console.WriteLine(a);
else if (a < b)
    System.Console.WriteLine(b);
else
    System.Console.WriteLine("Оба числа равны");

// Для примера работы цикла фор выведем все числа НУМ в строчку

for (int i = 1; i <= num; i = i + 3)
{
    System.Console.Write(i + " ");
}
// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int num = new Random().Next(100, 1000);
System.Console.WriteLine($"Было сгенерировано число {num}");
int right = num%10;
int left = (num / 100) * 10;
System.Console.WriteLine(left+right);

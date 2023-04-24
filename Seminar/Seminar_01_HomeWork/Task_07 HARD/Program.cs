// Напишите программу, которая принимает на вход целое число любой разрядности и на выходе показывает вторую цифру слева этого числа или говорит, что такой цифры нет. Через строку решать нельзя.
// 456111 -> 5
// 78 -> 8
// 9146548 -> 1
// 3 -> нет

System.Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9)
{
    while (number > 99) {
        number = number / 10;
    }
    
    System.Console.WriteLine(number%10);
}
else if (number < -9)
{
    while (number < -99) {
        number = number / 10;
    }
    
    System.Console.WriteLine(number%10);
}
else System.Console.Write("нет");
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.Write("Введите положительное целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
{
    for (int i = 1; i <= num; i++)
    {
        if (i % 2 == 0)
        {
            System.Console.Write(i + " ");
        }
        
    }
}
else System.Console.WriteLine("ОШИБКА!!!! Нужно ввести положительное целое число");
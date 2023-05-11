// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void CubeNum(int number)
{
    for (int i = 1; i <= number; ++i)
    {
        System.Console.Write(Math.Pow(i, 3));
        if (i < number)
        {
            System.Console.Write(", ");
        }
        else System.Console.Write(".");
    }
}

try
{
    System.Console.Write("Введите целое положительное число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 0) CubeNum(num);
    else System.Console.WriteLine("ОШИБКА Нужно водить положительное число больше ноля");
}
catch
{

    System.Console.WriteLine("ОШИБКА!!! Нужно вводить именно целое число!");
}
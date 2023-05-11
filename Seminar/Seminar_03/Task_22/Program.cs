// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

void SquareNum(int number)
{
    for (int i = 1; i <= number; ++i)
    {
        System.Console.Write(Math.Pow(i, 2));
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
    if (num > 0) SquareNum(num);
}
catch
{

    System.Console.WriteLine("ОШИБКА!!! Нужно вводить именно число!");
}


// 21 через массивы, 
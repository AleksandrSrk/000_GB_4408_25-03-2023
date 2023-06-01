// Задача 26: Напишите программу, которая принимает на вход ВЕЩЕСТВЕННОЕ число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5



int Lenght(double number)
{
    int count = 0;
    string res = Convert.ToString(number); // Создали переменную РЕС и в нее положили НАМБЕР, переведя ее в строку
    res = res.Replace(",", ""); // Удалили запятую из строки РЕС
    string res2 = res; // Создали переменную РЕС2, и в нее положили РЕС
    number = Convert.ToInt32(res); // В НАМБЕР положили  РЕС без запятой
    
    for (int i = 0; i < res2.Length; i++)
    {
        number = number / 10;
        count++;
    }

    return count;
}



try
{
    System.Console.Write("Введите натуральеное число: ");
    double num = Convert.ToDouble(Console.ReadLine());
    System.Console.WriteLine($"Количество цифр в числе {num} = {Lenght(num)}");
}
catch
{
    System.Console.WriteLine("!!! Ошибка! Нужно вводить целое число!");
}

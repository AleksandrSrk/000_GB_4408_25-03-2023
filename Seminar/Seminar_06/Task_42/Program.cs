// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

System.Console.WriteLine("Введите десятичное число");
int num = Convert.ToInt32(Console.ReadLine());
Transformation(num);

void Transformation(int number)
{
    string res = string.Empty;
    while (number != 0)
    {
        res = number%2 + res;
        number = number / 2;
    }
    System.Console.WriteLine(res);
    
}


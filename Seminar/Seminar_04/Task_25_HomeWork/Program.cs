// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int[] array = new int[2];
Arr();
Print();


Array Arr()
{

    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"Введите натуральное число {i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int Pow()
{
    int res = Convert.ToInt32(Math.Pow(array[0], array[1]));
    return res;
}

void Print()
{
    int res = Pow();
    System.Console.WriteLine($"Число {array[0]} в степени {array[1]} равно: {res}");
}
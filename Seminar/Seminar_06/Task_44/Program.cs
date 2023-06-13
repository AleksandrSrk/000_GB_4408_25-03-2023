// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// для k = 9 массив будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]

System.Console.WriteLine("Введите количество чисел Фибоначчи");
int num = Convert.ToInt32(Console.ReadLine());

PrintArray(Fibonacci(num));

int[] Fibonacci(int num)
{
    int[] array = new int[num];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        System.Console.Write($"{item} ");
    }
    //System.Console.WriteLine();
}

// void NegativPrintArray(int[] arr)
// {
//     foreach (int item in arr)
//     {
//         System.Console.Write($"{item * -1} ");
//     }
//     //System.Console.WriteLine();
// }

// int[] NegativFibonacci(int[] array)
// {
//     int temp = 0;

//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         temp = array[i];

//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }
//     return array;
// }
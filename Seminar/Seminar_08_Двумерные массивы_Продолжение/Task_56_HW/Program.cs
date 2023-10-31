// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

System.Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, cols];
int[] arrayShort = new int[rows];

FillArray(array);
PrintArray(array);
SumArray(array, arrayShort);
PrintArrayOne(arrayShort);
MinIndex(arrayShort);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    System.Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j],3}"); // !!! После аррая поставили запятую и указали сколько символов отводим под вывод информации
        }
        System.Console.WriteLine();
    }
}

int[] SumArray(int[,] array, int[] arrayShr)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        arrayShort[i] = sum;

    }
    System.Console.WriteLine();
    return arrayShr;

}

void PrintArrayOne(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}

void MinIndex(int[] mas)
{
    int index = 0;
    int min = mas[0];
    for (int i = 0; i < mas.Length; i++)
    {
        if (min > mas[i])
        {
            min = mas[i];
            index = i;
        }
    }
    
    System.Console.WriteLine($"Наименьшая сумма элементов находится в строке [{index+1}]");

}

// int[] BubbleSort(int[] mas)
// {

//     int temp;
//     for (int i = 0; i < mas.Length; i++)
//     {
//         for (int j = i + 1; j < mas.Length; j++)
//         {
//             if (mas[i] > mas[j])
//             {
//                 temp = mas[i];
//                 mas[i] = mas[j];
//                 mas[j] = temp;
//             }
//         }
//     }
//     return mas;
// }
// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

System.Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите искомое число");
int num = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, cols];

FillArray(array);
PrintArray(array);
SearchNumber(array, num);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 5); ;
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
    System.Console.WriteLine();
}

void SearchNumber(int[,] array, int number)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {


        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                System.Console.WriteLine($"Число {number} находится на позиции {i} : {j}");
                count++;
            }
        }

    }
    if (count == 0)
    {
        System.Console.WriteLine($"Числа {number} нет в заданном массиве");
    }
}
// Задайте двумерный массив с размером m*n, заполненный случайными целыми числами

// int m = 3;
// int n = 4;

using System;

System.Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());

int [,] array = new int [rows, cols];

FillArray(array);
PrintArray(array);

void FillArray (int [,] array){
    for (int i = 0; i < array.GetLength(0); i++) //GetLength(0) - значит берем размерность нулевого измерения, те количество строк тут
    {
        for (int j = 0; j < array.GetLength(1); j++) //GetLength(1) - единица значит идем по столбцам, первое измерение (в массиве два измерения в двумерном)
        {
            array[i,j] = new Random().Next(-30, 30);
        }
    }
}

void PrintArray (int [,] array) {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            System.Console.Write($"{array[i,j], 3}    "); // !!! После аррая поставили запятую и указали сколько символов отводим под вывод информации
        }
        System.Console.WriteLine();
    }
}
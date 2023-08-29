// Задача 48. Задайте двумерный массив М на Н, каждый элементв массиве находится по формуле Амн = м+н. Выведите на экран

System.Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите количество строк");
int cols = Convert.ToInt32(Console.ReadLine());

int [,] array = new int [rows, cols];

FillArray(array);
PrintArray(array);

void FillArray (int [,] array) {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = i+j;
        }
    }
}

void PrintArray (int [,] array) {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            System.Console.Write($"{array[i,j], 1}    "); // !!! После аррая поставили запятую и указали сколько символов отводим под вывод информации
        }
        System.Console.WriteLine();
    }
}
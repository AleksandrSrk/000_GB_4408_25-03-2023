// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

System.Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите количество строк");
int cols = Convert.ToInt32(Console.ReadLine());

int [,] array = new int [rows, cols];

FillArray(array);
PrintArray(array);
SumDiagonalArray(array);
ReverseArray(array);
PrintArray(array);
SumDiagonalArray(array);

void FillArray (int [,] array) {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = i+j;
        }
    }
}

void ReverseArray (int [,] array) {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 != 0)
            {
                array[i,j] = array[i,j] * array[i,j];
            }
        }
    }
    System.Console.WriteLine();
}

void SumDiagonalArray (int [,] array) {

    int sum = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                sum = sum + array[i,j];
            }
        }
    }
    System.Console.WriteLine($"Сумма главной диагонали равна {sum}");
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
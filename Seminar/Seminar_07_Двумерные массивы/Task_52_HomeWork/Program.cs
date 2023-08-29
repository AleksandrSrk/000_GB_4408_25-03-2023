// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

System.Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, cols];

FillArray(array);
PrintArray(array);
ArithmeticMean(array);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 10); ;
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

void ArithmeticMean(int[,] array)
{
    double[] arr = new double[cols];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int count = 0;
        double sum = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            count++;
            sum = sum + array[j, i];
        }
        arr[i] = sum / count;
    }
    System.Console.WriteLine("Среднее арифметическое каждого столбца: ");
    PrintArray1(arr);
    

}

void PrintArray1(double[] array1)
{
    int numColumn = 1;
    for (int i = 0; i < array1.Length; i++)
    {
        System.Console.WriteLine($"{numColumn}) {Math.Round(array1[i], 2)} ");
        numColumn++;

    }
    System.Console.WriteLine();
}

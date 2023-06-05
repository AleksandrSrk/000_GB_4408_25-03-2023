// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

try
{
    System.Console.Write("Введите размерность массива положительным натуральным числом больше 0: ");
    int size = Convert.ToInt32(Console.ReadLine());

    if (size > 0)
    {
        double[] array = new double[size];

        FillArray(array);
        BubbleSort(array);
        System.Console.Write("Разница между макс и мин элементами массива ");
        PrintArray(array);
        System.Console.WriteLine($"равна {Difference(array)}");

    }
    else System.Console.WriteLine("ОШИБКА! Вы задали массив без элементов. ");



    void FillArray(double[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Math.Round(new Random().NextDouble() * 100, 2);
        }
    }

    void PrintArray(double[] arr)
    {
        foreach (double item in arr)
        {
            System.Console.Write($"{item} ");
        }
    }

    void BubbleSort(double[] array)
    {
        for (int i = 0; i < array.Length; i++)
            for (int j = 0; j < array.Length - 1; j++)
                if (array[j] > array[j + 1])
                {
                    double t = array[j + 1];
                    array[j + 1] = array[j];
                    array[j] = t;
                }
    }

    double Difference(double[] array)
    {
        return Math.Round((array[array.Length - 1] - array[0]), 2);
    }
}
catch
{

    System.Console.WriteLine("!!! ОШИБКА. Нужно ввести размерность массива положительным натуральным числом больше 0");
}
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

try
{
    System.Console.Write("Введите размерность массива положительным натуральным числом больше 0: ");
    int size = Convert.ToInt32(Console.ReadLine());
    if (size > 0)
    {
        int[] array = new int[size];
        FillArray(array);
        System.Console.Write("Сумма элементов на нечетных позициях в массиве ");
        PrintArray(array);
        System.Console.WriteLine($"равна {SumElements(array)}");
    }
    else System.Console.WriteLine("ОШИБКА! Вы задали массив без элементов. ");



    void FillArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(-100, 101);
        }
    }

    void PrintArray(int[] arr)
    {
        foreach (int item in arr)
        {
            System.Console.Write($"{item} ");
        }
    }

    int SumElements(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (i % 2 != 0)
            {
                sum = sum + arr[i];
            }
        }
        return sum;
    }
}
catch (System.Exception)
{

    System.Console.WriteLine("ОШИБКА! Нужно ввести размерность массива положительным натуральным числом больше 0");
}
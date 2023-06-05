// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


try
{
    System.Console.Write("Введите размерность массива положительным натуральным числом: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];

    FillArray(array);
    System.Console.Write("В массиве ");
    PrintArray(array);
    System.Console.WriteLine($"'{EvenNumber(array)}' четных чисел");

    void FillArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(0, 1000);
        }
    }

    void PrintArray(int[] arr)
    {
        foreach (int item in arr)
        {
            System.Console.Write($"{item} ");
        }
    }

    int EvenNumber(int[] arr)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }

}
catch
{
    System.Console.WriteLine("!!! ОШИБКА. Нужно ввести размерность массива положительным натуральным числом");
}
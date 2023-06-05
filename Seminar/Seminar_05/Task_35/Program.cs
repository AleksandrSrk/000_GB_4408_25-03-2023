// Задача 35: Задайте одномерный массив из 15 случайных чисел в диапазоне от -100 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// ДОПОЛНИЛ ЗАДАЧУ: ПУСТЬ ВЫДАСТ ТОЛЬКО ТАКОЙ МАССИВ, В КОТОРОМ ЭЛЕМЕНТОВ ИЗ ОТРЕЗКА [10,99] БУДЕТ 5

// Пример для массива из 5, а не 15 элементов. В своём решении сделайте для 15
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] array = new int[15];



// System.Console.Write($"В массиве ");
// PrintArray(array);
// System.Console.WriteLine($" {SearchElement(array)} элементов в диапазоне [10,99]");

while (SearchElement(array) != 5)
{
    Console.Clear();
    FillArray(array);
    System.Console.Write($"В массиве ");
    PrintArray(array);
    System.Console.WriteLine($" {SearchElement(array)} элементов в диапазоне [10,99]");
}

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

int SearchElement(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 9 & arr[i] < 100)
        {
            count++;
        }
    }
    return count;
}
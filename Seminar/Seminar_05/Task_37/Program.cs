// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

System.Console.Write("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
//int [] array = new int [];
Console.Clear();
FillArray(array);
PrintArray(array);
Multiple(array);


void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-50, 51);
    }
}

void PrintArray(int[] arr)
{
    System.Console.Write($"Заданный массив из {size} элементов: ");
    foreach (int item in arr)
    {
        System.Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}

void Multiple(int[] arr)
{
    int count = 1;

    if (arr.Length % 2 == 0)
    {
        int[] multiYes = new int[arr.Length / 2];

        for (int i = 0; i < arr.Length / 2; i++)
        {
            multiYes[i] = arr[i] * arr[arr.Length - count];
            count++;
        }
        System.Console.Write("Элементы после умножения: ");
        foreach (int item in multiYes)
        {
            System.Console.Write($"{item} ");
        }
    }

    else if (arr.Length % 2 != 0)
    {
        int[] multiYes = new int[(arr.Length / 2) + 1];
        multiYes[multiYes.Length-1] = arr[arr.Length / 2];

        for (int i = 0; i < arr.Length / 2; i++)
        {
            multiYes[i] = arr[i] * arr[arr.Length - count];
            count++;
        }
        System.Console.Write("Элементы после умножения: ");
        foreach (int item in multiYes)
        {
            System.Console.Write($"{item} ");
        }
    }
}


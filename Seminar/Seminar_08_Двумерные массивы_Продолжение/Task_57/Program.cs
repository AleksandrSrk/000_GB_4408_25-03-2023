// Составить частотный словарь элементов двумерного массива. Сколько раз встречается каждый элемент в массиве. 
// В двумерном массиве только числа от 0 до 9 включительно

System.Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, cols];

FillArray(array);
PrintArray(array);
CounterArray(array);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
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

void CounterArray(int[,] array)
{
    for (int i = 0; i <= 9; i++)
    {
        int count = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                if (array[j, k] == i)
                {
                    count++;
                }
            }
        }
        if (count != 0)
        {
            System.Console.WriteLine($"Элемент {i} встречается {count} раз");
        }

    }
}
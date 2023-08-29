// Задача HARD SORT необязательная. Считается за три обязательных
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.

// Например, задан массив:
// 1 4 7 2
// 5 9 10 3

// После сортировки
// 1 2 3 4
// 5 7 9 10

// Сперва заполнил двум массив числами от -10 до 10, затем сделал из двумерного одномерный массив, отсортировал его по убыванию, затем заполнил двумерный массив из одномерного

System.Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, cols];
int[] array1 = new int[rows * cols];

FillArray(array);
PrintArray(array);
FillArray1(array, array1);
PrintArray1(array1);
SortArray(array1);
PrintArray1(array1);
FillArrayAfterSort(array, array1);
PrintArray(array);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100); ;
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
            System.Console.Write($"{array[i, j],4}"); // !!! После аррая поставили запятую и указали сколько символов отводим под вывод информации
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void FillArray1(int[,] array, int[] array1)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array1[count] = array[i, j];
            count++;
        }
    }
}

void PrintArray1(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        System.Console.Write($"{array1[i]} ");

    }
    System.Console.WriteLine();
}

void SortArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        for (int j = 0; j < array1.Length-1; j++)
        {
            if (array1[j] < array1[j + 1])
            {
                int t = array1[j + 1];
                array1[j + 1] = array1[j];
                array1[j] = t;

            }
        }
    }
}

void FillArrayAfterSort(int[,] array, int[] array1)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            array[i, j] = array1[count];
            count++;
        }
    }
}




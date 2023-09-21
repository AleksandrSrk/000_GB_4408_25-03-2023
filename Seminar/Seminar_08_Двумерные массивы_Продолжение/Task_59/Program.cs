// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

System.Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, cols];



FillArray(array);
PrintArray(array);
//PrintArrayOne(MinNumberArray(array));
int[] shortArray = MinNumberArray(array);
int[,] finArray = new int[rows, cols];
PrintArrayOne(shortArray);
System.Console.WriteLine();
PrintShortArray(array, shortArray);
FillShortArray(array, finArray, shortArray);
PrintArray(finArray);

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

void PrintArrayOne(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write($"{item} ");
    }
}

int[] MinNumberArray(int[,] array)
{
    int min = array[0, 0];
    int minI = 0;
    int minJ = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                minI = i;
                minJ = j;
            }
        }

    }
    int[] minimum = { min, minI, minJ };
    return minimum;
}

void PrintShortArray(int[,] array, int[] shArr)
{
    System.Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i != shArr[1] & j != shArr[2])
            {
                System.Console.Write($"{array[i, j],3}");
            }
        }
        System.Console.WriteLine();
    }
}

int[,] FillShortArray(int[,] array, int[,] newArray, int[] shArr)
{
    //System.Console.WriteLine();
    // int a = 0;
    // int b = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i != shArr[1] & j != shArr[2])
            {
                //System.Console.Write($"{array[i, j],3}");
                newArray[i, j] = array[i, j];
                // a++;
                // b++;
            }
            else newArray[i, j] = -1;
        }
        //System.Console.WriteLine();
    }
    return newArray;
}


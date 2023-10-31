// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

//Проверить чтобы число столбцов матрицы а было равно числу строк матрицы б

System.Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] firstArr = new int[rows, cols];
int[,] twoArr = new int[cols, rows];
int[,] resArr = new int[cols, rows];

FillArray(firstArr);
FillArray(twoArr);
PrintArray(firstArr);
PrintArray(twoArr);
MatrixArray(firstArr, twoArr, resArr);
PrintArray(resArr);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
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
}

void MatrixArray(int[,] oneMatrix, int[,] twoMatrix, int[,] resMatrix)
{
    for (int i = 0; i < resMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < oneMatrix.GetLength(1); k++)
            {
                sum += oneMatrix[i, k] * twoMatrix[k, j];
            }
            resMatrix[i, j] = sum;
        }
    }
}

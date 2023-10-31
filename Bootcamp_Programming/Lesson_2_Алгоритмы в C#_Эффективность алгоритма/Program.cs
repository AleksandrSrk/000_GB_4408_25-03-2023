/*  
    Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
    
    Например, даны 2 матрицы:
    2 4 | 3 4
    3 2 | 3 3

    Результирующая матрица будет:
    18 20
    15 18

    (a[0,0]b[0,0] + a[0,1]b[1,0])  (a[0,0]b[0,1] + a[0,1]b[1,1])
    (a[1,0]b[0,0] + a[1,1]b[1,0])  (a[1,0]b[0,1] + a[1,1]b[1,1]) 
*/


Console.Write("Введите первую размерность первого массива: ");
int rowsOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую размерность первого массива: ");
int columsOne = Convert.ToInt32(Console.ReadLine());
int[,] matrixOne = new int[rowsOne, columsOne];
Console.Write("Введите первую размерность второго массива: ");
int rowsTwo = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую размерность второго массива: ");
int columsTwo = Convert.ToInt32(Console.ReadLine());
int[,] matrixTwo = new int[rowsTwo, columsTwo];

if (columsOne == rowsTwo)
{
    int[,] matrixThree = new int[rowsOne, columsTwo];
     void InputArray(int[,] array)
     {
         for(int i = 0; i < array.GetLength(0); i++)
         {
             for(int j = 0; j < array.GetLength(1); j++)
             {
                 array[i, j] = new Random().Next(1, 10);
             }
         }
    }
    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j == 0)
                {
                    System.Console.Write("[");
                }
                System.Console.Write(array[i, j]);
                if (j == array.GetLength(1) - 1)
                {
                    System.Console.Write("]");
                }
                else
                {
                    System.Console.Write("; ");
                }
            }
            System.Console.WriteLine();
        }
    }
    void MultiplyMatrix(int[,] firstMatrix, int[,] secomdMartrix, int[,] resultMatrix)
    {
        for (int i = 0; i < resultMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < resultMatrix.GetLength(1); j++)
            {
                int sum = 0;
                for (int k = 0; k < firstMatrix.GetLength(1); k++)
                {
                    sum += firstMatrix[i, k] * secomdMartrix[k, j];
                }
                resultMatrix[i, j] = sum;
            }
        }
    }
        InputArray(matrixOne);
        InputArray(matrixTwo);
        PrintArray(matrixOne);
        System.Console.WriteLine();
        PrintArray(matrixTwo);
        System.Console.WriteLine();
        MultiplyMatrix(matrixOne, matrixTwo, matrixThree);
        PrintArray(matrixThree);
}
else
{
    System.Console.WriteLine
    ("Ошибка! Нельзя найти произведение двух заданных матриц, так как количество строк первой матрицы не равно количеству строк второй!");
}



// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и и отдельно сумму элементов 
//обратной диагонали
// Например, задан массив:
// 1 4 7
// 5 9 2
// 8 4 2
// Сумма элементов главной диагонали: 1+9+2 = 12
// сумма элементов обратной диагонали 8 + 9 + 7 = 24

System.Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите количество строк");
int cols = Convert.ToInt32(Console.ReadLine());

int [,] array = new int [rows, cols];

FillArray(array);
PrintArray(array);
SumDiagonalArray(array);

void FillArray (int [,] array) {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(-30, 30);;
        }
    }
}

void PrintArray (int [,] array) {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            System.Console.Write($"{array[i,j], 3}    "); // !!! После аррая поставили запятую и указали сколько символов отводим под вывод информации
        }
        System.Console.WriteLine();
    }
}

void SumDiagonalArray (int [,] array) {

    int sum = 0;
    int revsum = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                sum = sum + array[i,j];
            }
            //cols = cols-1;
        }
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i + j == array.GetLength(0)-1) // cols-1
            {
                revsum = revsum + array[i,j];
            }
        }
    }


    System.Console.WriteLine($"Сумма главной диагонали равна {sum}");
    System.Console.WriteLine($"Сумма обратной диагонали равна {revsum}");
}
// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

Console.Clear();
Random rand = new Random();
int[] arr = new int[12];

FillArray();
SumNegativAndPositiv(arr);



void FillArray()
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(-9, 10);
    }
}

void SumNegativAndPositiv(int[] array)
{
    int positiv = 0;
    int negativ = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 0)
        {
            positiv = positiv + arr[i];
        }
        else negativ = negativ + arr[i];
    }
    System.Console.Write("Сумма в массиве ");
    Console.Write("[{0}]", string.Join(", ", arr));
    System.Console.WriteLine($" положительных чисел {positiv} и отрицательных {negativ}");
}
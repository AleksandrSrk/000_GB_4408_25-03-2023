// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

Console.Clear();
int[] array = new int[12];
FillArray(array);
PrintArray(array);
//PrintArray(FindSums(array));
int [] rez = FindSums(array);
System.Console.WriteLine($"Сумма положительных элементов равна {rez[0]}, отрицательных {rez[1]}");


void FillArray(int[] array) // Метод заполнения массива
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
}

void PrintArray(int[] array) //Метод печати массива
{
    foreach (int item in array) // ФОРИЧ - он не проходит по индексам, а напрямую по элементам. Но в таком цикле ничего нельзя менять
    {
        System.Console.Write($"{item} ");
        
    }
    System.Console.WriteLine();
}

int[] FindSums(int[] array)
{
    int sumP = 0;
    int sumN = 0;

    foreach (int item in array)
        if (item >= 0)
            sumP = sumP + item;
        else
            sumN = sumN + item;

    int [] result = {sumP, sumN};
    return result;
}
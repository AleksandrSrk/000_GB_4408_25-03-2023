// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

Console.Clear();
int[] array = new int[12];

FillArray(array);
PrintArray(array);
InvertArray(array);
PrintArray(array);

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

void InvertArray(int[] array) // Метод меняем полярность массива
{
    for (int i = 0; i < array.Length; i++)
    {
       array[i] = array[i] * -1;
    }
}

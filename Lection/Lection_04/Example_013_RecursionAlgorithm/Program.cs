string[,] table = new string[2, 5];
table[1, 2] = "слово"; // Положили в ячейку с индексом троки 1 и индексом столбца 2 "слово"

/*
for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        System.Console.WriteLine($"-{table[rows, columns]}-");
    }
}
System.Console.WriteLine();
*/

int[,] matrix = new int[3, 4];
Printarray(matrix);
FillArray(matrix);
System.Console.WriteLine();
Printarray(matrix);


void Printarray(int[,] matr) // Метод печати массива
{

    for (int i = 0; i < matr.GetLength(0); i++) // C помощью matrix.GetLength(0) мы взяли количество строк
    {
        for (int j = 0; j < matr.GetLength(1); j++) // C помощью matrix.GetLength(1) мы взяли количество столбцов
        {
            System.Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void FillArray(int[,] matr) // Метод заполнения массива
{
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
        for (int j = 0; j < matr.GetLength(1); j++) 
        {
            matr[i, j] = new Random().Next(1, 10); // 1-9
        }

    }
}
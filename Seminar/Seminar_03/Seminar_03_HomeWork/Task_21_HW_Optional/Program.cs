// Задача 21 - HARD необязательная

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. 
// Сначала задается N с клавиатуры, потом задаются координаты точек.

System.Console.Write("Введите количество плоскостей: ");
int lenghtArray = (Convert.ToInt32(Console.ReadLine())) * 2;
FillingFrray(lenghtArray);


Array FillingFrray(int number)
{

    int[] arr = new int[number];
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"Введите координату {i + 1}: ");
        int point = Convert.ToInt32(Console.ReadLine());
        arr[i] = point;
    }

    return arr;
}
//System.Console.WriteLine(arr[1]);

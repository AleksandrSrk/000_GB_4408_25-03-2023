// Задача 21 - HARD необязательная

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. 
// Сначала задается N с клавиатуры, потом задаются координаты точек.

System.Console.Write("Введите количество плоскостей: ");
try
{
    int lenghtArray = (Convert.ToInt32(Console.ReadLine())) * 2;
    double[] arr = new double[lenghtArray];
    double res = 0;

    FillingFrray();
    DistancePoint();

    // Console.WriteLine("[{0}]", string.Join(", ", arr)); // ПЕЧАТЬ МАССИВА
    System.Console.WriteLine($"Длина вектора между двумя точками: {Math.Round(Math.Sqrt(res), 3)}");

    Array FillingFrray() // Заполняем массив координатами
    {
        for (int i = 0; i < arr.Length; i++)
        {
            System.Console.Write($"Введите поочередно координаты двух точек в плоскости. Координата {i + 1}: ");
            double point = Convert.ToDouble(Console.ReadLine());
            arr[i] = point;
        }
        return arr;
    }

    double DistancePoint() // Вычисляем расстояние. Цикл длится массив пополам. Затем работаем с цифрами из ячеек массива (0 и последняя, 1 и предпоследняя, 2 и 2 с конца и тд.)
    {
        int right = lenghtArray - 1;
        int left = lenghtArray / 2 - 1;

        for (int i = 0; i < lenghtArray / 2; i++)
        {
            res = res + (Math.Pow((arr[right] - arr[left]), 2));
            right--;
            left--;
        }
        return res;
    }

}
catch
{
    System.Console.WriteLine("ОШИБКА!!! Нужно ввести целое число.");
}


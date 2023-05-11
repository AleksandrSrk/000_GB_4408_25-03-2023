// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

void distancePoint(double pointaX, double pointaY, double pointbX, double pointbY)
{
    double line = Math.Sqrt(((pointaX - pointbX) * (pointaX - pointbX)) + ((pointaY - pointbY) * (pointaY - pointbY)));
    double res = Math.Round(line, 3);
    System.Console.WriteLine($"Расстояние между точками А и В: {res}");
}


try
{
    System.Console.Write("Введите координату aX: ");
    double aX = Convert.ToDouble(Console.ReadLine());
    System.Console.Write("Введите координату aY: ");
    double aY = Convert.ToDouble(Console.ReadLine());
    System.Console.Write("Введите координату bX: ");
    double bX = Convert.ToDouble(Console.ReadLine());
    System.Console.Write("Введите координату bY: ");
    double bY = Convert.ToDouble(Console.ReadLine());

    distancePoint(aX, aY, bX, bY);
}
catch 
{

    System.Console.WriteLine("ОШИБКА!!! Нужно вводить именно числа!");
}

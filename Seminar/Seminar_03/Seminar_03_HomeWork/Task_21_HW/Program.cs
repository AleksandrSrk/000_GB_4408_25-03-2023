// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void distancePoint(double pointax, double pointbx, double pointay, double pointby, double pointaz, double pointbz)
{
    double line = Math.Sqrt(Math.Pow((pointbx - pointax), 2) + Math.Pow((pointby - pointay), 2) + Math.Pow((pointbz - pointaz), 2));
    double res = Math.Round(line, 3);
    System.Console.WriteLine($"Расстояние между точками А и В: {res}");
}


try
{
    System.Console.Write("Введите координату ax: ");
    double ax = Convert.ToDouble(Console.ReadLine());
    System.Console.Write("Введите координату ay: ");
    double ay = Convert.ToDouble(Console.ReadLine());
    System.Console.Write("Введите координату az: ");
    double az = Convert.ToDouble(Console.ReadLine());

    System.Console.Write("Введите координату bx: ");
    double bx = Convert.ToDouble(Console.ReadLine());
    System.Console.Write("Введите координату by: ");
    double by = Convert.ToDouble(Console.ReadLine());
    System.Console.Write("Введите координату bz: ");
    double bz = Convert.ToDouble(Console.ReadLine());

    distancePoint(ax, bx, ay, by, az, bz);
}
catch
{

    System.Console.WriteLine("ОШИБКА!!! Нужно вводить именно числа!");
}
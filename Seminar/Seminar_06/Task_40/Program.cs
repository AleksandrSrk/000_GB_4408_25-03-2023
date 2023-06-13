// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
// Если да, то вывести всю информацию по нему - 
// площадь, периметр, значения углов треугольника в градусах, является ли он прямоугольным, равнобедренным, равносторонним.

System.Console.WriteLine("Введите первую длину");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите вторую длину");
int num2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третью длину");
int num3 = Convert.ToInt32(Console.ReadLine());

//Inequality(num1, num2, num3);
System.Console.WriteLine($"Треугольник с заданными сторонами возможен: {Inequality(num1, num2, num3)}");
//Inequality(num1, num2, num3);
Info(num1, num2, num3);

bool Inequality(int a, int b, int c)
{
    bool flag = false;
    if (a < b + c & b < a + c & c < b + a)
    {
        flag = true;
    }
    return flag;
}

void Info(int a, int b, int c)
{
    int p = (a + b + c) / 2;
    int corner1 = (a * a + c * c - b * b) / 2 * (a * c);
    int corner2 = (a * a + b * b - c * c) / 2 * (a * b);
    int corner3 = (b * b + c * c - a * a) / 2 * (c * b);

    if (Inequality(num1, num2, num3))
    {

        System.Console.WriteLine($"Площадь треугольника: {Math.Round((Math.Sqrt(p * (p - a) * (p - b) * (p - c))),3)}");
        System.Console.WriteLine($"Периметр треугольника: {p * 2}");
        System.Console.WriteLine($"Углы треугольника: ac:{corner1}, ab:{corner2}, bc:{corner3}");
        if (corner1 == 90 || corner2 == 90 || corner3 == 90)
        {
            System.Console.WriteLine($"Треугольник является прямоугольным");
        }
        if (a == b || a == c || c == b)
        {
            System.Console.WriteLine($"Треугольник является равнобедренным");
        }
        if (a == b && a == c && c == b)
        {
            System.Console.WriteLine($"Треугольник является равносторонним");
        }
    }

}
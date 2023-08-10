// задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа. Определить , является ли это сторонами треугольника. 
// Если да, то вывести всю информацию по нему 
// - площадь, периметр, значения углов треугольника в градусах, является ли он прямоугольным, равнобедренным, равносторонним.


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

void Info(double a, double b, double c)
{
    double p = (a + b + c) / 2;

    double powA = Math.Pow(a, 2);
    double powB = Math.Pow(b, 2);
    double powC = Math.Pow(c, 2);

    double corner1 = Math.Acos(Math.Cos((powA + powC - powB) / 2 * (a * c)));
    double corner2 = Math.Cos((powA + powB - powC) / 2 * (a * b));
    double corner3 = Math.Acos((powB + powC - powA) / (2 * c * b));
    double sdsd = Math.Sin(corner3) / a;
    double b1  = (Math.Asin (sdsd) * 180)/Math.PI ;

    if (Inequality(num1, num2, num3))
    {

        System.Console.WriteLine($"Площадь треугольника: {Math.Round((Math.Sqrt(p * (p - a) * (p - b) * (p - c))),3)}");
        System.Console.WriteLine($"Периметр треугольника: {p * 2}");
        System.Console.WriteLine($"Углы треугольника: ac:{b1}, ab:{corner2}, bc:{corner3}");
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
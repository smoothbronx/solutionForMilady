using ConsoleApp6.triangles;

Console.WriteLine("Введите первую сторону:");

double a = double.Parse(Console.ReadLine());
Equilateral equilateral = new Equilateral(a);
Console.WriteLine($"Площадь равносторонненго треугольника: {equilateral.Area():F2};" +
                  $" периметр равносторонненго треугольника: {equilateral.Perimeter():F2}");

Console.WriteLine("Введите вторую сторону:");

double b = double.Parse(Console.ReadLine());
Rectangular rectangular = new Rectangular(a, b);
Console.WriteLine($"Площадь прямоугольного треугольника: {rectangular.Area():F2};" +
                  $" периметр прямоугольного треугольника: {rectangular.Perimeter():F2}");

Console.WriteLine("Введите угол:");

double angle = double.Parse(Console.ReadLine());
Isosceles isosceles = new Isosceles(a, b, angle);
Console.WriteLine($"Площадь равнобедренного треугольника: {isosceles.Area():F2};" +
                  $" периметр равнобедренного треугольника: {isosceles.Perimeter():F2}");
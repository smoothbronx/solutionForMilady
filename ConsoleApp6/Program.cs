using ConsoleApp6;

// Равносторонний треугольник
var equilateral = new Triangle(3, 3, 3, 60, 60, 60);
Console.WriteLine("Sides\tAngles\tHeights\n" +
                  $"a = {equilateral.ASide}\tA = {equilateral.AAngle}\tH(a) = {equilateral.AHeight():F2}\n" +
                  $"b = {equilateral.BSide}\tB = {equilateral.BAngle}\tH(b) = {equilateral.BHeight():F2}\n" +
                  $"c = {equilateral.CSide}\tC = {equilateral.CAngle}\tH(c) = {equilateral.CHeight():F2}\n");
Console.WriteLine($"Тип треугольника: {equilateral.Type()}");
Console.WriteLine($"Периметр: {equilateral.Perimeter():F2}");
Console.WriteLine($"Площадь: {equilateral.Area():F2}\n\n");

// Прямоугольный треугольник
var straight = new Triangle(3, 4, 5, 45, 45, 90);
Console.WriteLine("Sides\tAngles\tHeights\n" +
                  $"a = {straight.ASide}\tA = {straight.AAngle}\tH(a) = {straight.AHeight():F2}\n" +
                  $"b = {straight.BSide}\tB = {straight.BAngle}\tH(b) = {straight.BHeight():F2}\n" +
                  $"c = {straight.CSide}\tC = {straight.CAngle}\tH(c) = {straight.CHeight():F2}\n");
Console.WriteLine($"Тип треугольника: {straight.Type()}");
Console.WriteLine($"Периметр: {straight.Perimeter():F2}");
Console.WriteLine($"Площадь: {straight.Area():F2}\n\n");

// Равнобедренный треугольник
var isosceles = new Triangle(4, 4, 2, 70, 70, 40);
Console.WriteLine("Sides\tAngles\tHeights\n" +
                  $"a = {isosceles.ASide}\tA = {isosceles.AAngle}\tH(a) = {isosceles.AHeight():F2}\n" +
                  $"b = {isosceles.BSide}\tB = {isosceles.BAngle}\tH(b) = {isosceles.BHeight():F2}\n" +
                  $"c = {isosceles.CSide}\tC = {isosceles.CAngle}\tH(c) = {isosceles.CHeight():F2}\n");
Console.WriteLine($"Тип треугольника: {isosceles.Type()}");
Console.WriteLine($"Периметр: {isosceles.Perimeter():F2}");
Console.WriteLine($"Площадь: {isosceles.Area():F2}");

// Разносторонний треугольник
var versatile = new Triangle(3, 4, 2, 70, 20, 90);
Console.WriteLine("Sides\tAngles\tHeights\n" +
                  $"a = {versatile.ASide}\tA = {versatile.AAngle}\tH(a) = {versatile.AHeight():F2}\n" +
                  $"b = {versatile.BSide}\tB = {versatile.BAngle}\tH(b) = {versatile.BHeight():F2}\n" +
                  $"c = {versatile.CSide}\tC = {versatile.CAngle}\tH(c) = {versatile.CHeight():F2}\n");
Console.WriteLine($"Тип треугольника: {versatile.Type()}");
Console.WriteLine($"Периметр: {versatile.Perimeter():F2}");
Console.WriteLine($"Площадь: {versatile.Area():F2}");
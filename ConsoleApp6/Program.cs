using ConsoleApp6;

double ConvertTime(double hours, double minutes)
{
    return (hours * 60 + minutes) * 60;
}

double ConvertTimeOrThrowException(double hours, double minutes)
{
    if (double.IsNegative(hours)) throw new Exception("Hours cannot be less than zero");
    if (double.IsNegative(minutes)) throw new Exception("Minutes cannot be less than zero");

    return ConvertTime(hours, minutes);
}

double ConvertTimeOrThrowArgumentException(double hours, double minutes)
{
    if (double.IsNegative(hours)) throw new ArgumentException("Hours cannot be less than zero");
    if (double.IsNegative(minutes)) throw new ArgumentException("Minutes cannot be less than zero");
    
    return ConvertTime(hours, minutes);
}

double ConvertTimeOrThrowSpecificException(double hours, double minutes)
{
    if (double.IsNegative(hours)) throw new LessZeroException("Hours", hours);
    if (double.IsNegative(minutes)) throw new LessZeroException("Minutes", minutes);
    
    return ConvertTime(hours, minutes);
}

void Main()
{
    Console.Write("Введите значение часов: ");
    var hours = double.Parse(Console.ReadLine()!);
    
    Console.Write("Введите значение минут: ");
    var minutes = double.Parse(Console.ReadLine()!);

    try
    {
        var result = ConvertTimeOrThrowSpecificException(hours, minutes);
        Console.WriteLine($"Результат преобразования: {result:F2}");
    }
    catch (LessZeroException exception)
    {
        Console.WriteLine(exception.Message);
        throw;
    }
}
Main();
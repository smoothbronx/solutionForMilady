using ConsoleApp6;

var aeroflots = new Aeroflot<int>[4];
for (var index = 0; index < aeroflots.Length; index++)
{
    Console.Write("Введите номер рейса: ");
    var flightNumber = int.Parse(Console.ReadLine()!);
    
    Console.Write("Введите пункт назначения: ");
    var destination = Console.ReadLine()!;
    
    Console.Write("Введите тип самолета: ");
    var aircraftType = Console.ReadLine()!;
    Console.WriteLine();

    aeroflots[index] = new Aeroflot<int>(flightNumber, destination, aircraftType);
}

var aeroflotsList = aeroflots.ToList();
aeroflotsList.Sort((x, y) => y.CompareTo(x));

Console.WriteLine("\nСписок введенных объектов:");
foreach (var aeroflot in aeroflotsList)
    aeroflot.Display();

Console.Write("\nВведите интересующий пункт назначения: ");
var targetDestination = Console.ReadLine()!;

var searchResult = aeroflotsList.FindAll((item) => item.Destination == targetDestination);
if (searchResult.Count != 0)
{
    foreach (var aeroflot in searchResult)
        aeroflot.Display();
}
else
{
    Console.WriteLine("Самолеты, идущие в интересующий пункт назначения, отсутствуют");
}

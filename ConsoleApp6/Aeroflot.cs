namespace ConsoleApp6;

public class Aeroflot<T> : ICloneable, IComparable
{
    public T FlightNumber { get; set; }

    public string Destination { get; set; }

    public string AircraftType { get; set; }

    public Aeroflot(T flightNumber, string destination, string aircraftType)
    {
        FlightNumber = flightNumber;
        Destination = destination;
        AircraftType = aircraftType;
    }

    public object Clone()
    {
        return new Aeroflot<T>(FlightNumber, Destination, AircraftType);
    }

    public int CompareTo(Aeroflot<string> other)
    {
        if (typeof(T) == typeof(string))
            return string.CompareOrdinal(Convert.ToString(FlightNumber), other.FlightNumber);
        return 1;
    }
    
    public int CompareTo(Aeroflot<int> other)
    {
        if (typeof(T) == typeof(string))
            return -1;
        return other.FlightNumber - Convert.ToInt32(FlightNumber);
    }
    
    public int CompareTo(object? obj)
    {
        if (obj == null) return 1;
        throw new ArgumentException("Object is not a Aeroflot");
    }

    public override string ToString()
    {
        return $"<Aeroflot> [{FlightNumber}, {Destination}, {AircraftType}]";
    }

    public void Display()
    {
        Console.WriteLine(ToString());
    }
}
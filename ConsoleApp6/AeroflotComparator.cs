namespace ConsoleApp6;

public class AeroflotComparator: IComparer<Aeroflot<string>>, IComparer<Aeroflot<int>>
{
    public int Compare(Aeroflot<string>? x, Aeroflot<string>? y)
    {
        if (x == null) return 1;
        if (y == null) return -1;
        return CompareAircraftType(x.AircraftType, y.AircraftType);
    }

    public int Compare(Aeroflot<int>? x, Aeroflot<int>? y)
    {
        if (x == null) return 1;
        if (y == null) return -1;
        return CompareAircraftType(x.AircraftType, y.AircraftType);
    }

    private int CompareAircraftType(string x, string y)
    {
        return string.CompareOrdinal(x, y);
    }
}
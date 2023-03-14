namespace ConsoleApp6.triangles;

public class Rectangular : ITriangle
{
    private double a;
    private double b;

    public double A
    {
        get { return a; }
        set
        {
            if (value > 0) a = value;
        }
    }

    public double B
    {
        get { return b; }
        set
        {
            if (value > 0) b = value;
        }
    }

    public Rectangular(double a, double b)
    {
        A = a;
        B = b;
    }

    public double Area()
    {
        return (A * B) / 2;
    }

    public double Perimeter()
    {
        return A + B + Math.Sqrt(A * A + B * B);
    }
}
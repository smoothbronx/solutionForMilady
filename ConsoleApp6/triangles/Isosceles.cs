namespace ConsoleApp6.triangles;

public class Isosceles : ITriangle
{
    private double a;
    private double b;
    private double angle;

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

    public double Angle
    {
        get { return angle; }
        set
        {
            if (value > 0) angle = value;
        }
    }

    public Isosceles(double a, double b, double angle)
    {
        A = a;
        B = b;
        Angle = angle;
    }

    public double Area()
    {
        return a * b * Math.Sin(angle) / 2;
    }

    public double Perimeter()
    {
        return 2 * a + b;
    }
}
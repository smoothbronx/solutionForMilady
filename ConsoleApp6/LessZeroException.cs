namespace ConsoleApp6;

public class LessZeroException : Exception
{
    public LessZeroException(string name) : base($"{name} cannot be less than zero.")
    {
    }

    public LessZeroException() : base("Value cannot be less than zero.")
    {
    }

    public LessZeroException(string name, double value) : base($"{name} cannot be less than zero. <{name}: {value:F2}>")
    {
    }
}
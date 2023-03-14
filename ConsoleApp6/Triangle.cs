namespace ConsoleApp6;

public class Triangle
{
    private double _aSide;
    private double _bSide;
    private double _cSide;

    private double _aAngle;
    private double _bAngle;
    private double _cAngle;

    public double ASide
    {
        get => _aSide;
        set
        {
            if (value <= 0)
                throw new Exception("Длина стороны не может быть меньше или равна нулю");
            _aSide = value;
        }
    }

    public double BSide
    {
        get => _bSide;
        set
        {
            if (value <= 0)
                throw new Exception("Длина стороны не может быть меньше или равна нулю");
            _bSide = value;
        }
    }

    public double CSide
    {
        get => _cSide;
        set
        {
            if (value <= 0)
                throw new Exception("Длина стороны не может быть меньше или равна нулю");
            _cSide = value;
        }
    }

    public double AAngle
    {
        get => _aAngle;
        set
        {
            var available = 180 - (_bAngle + _cAngle);
            if (value > available)
                throw new Exception("Сумма углов треугольника не может быть больше 180 градусов");
            _aAngle = value;
        }
    }

    public double BAngle
    {
        get => _bAngle;
        set
        {
            var available = 180 - (_aAngle + _cAngle);
            if (value > available)
                throw new Exception("Сумма углов треугольника не может быть больше 180 градусов");
            _bAngle = value;
        }
    }

    public double CAngle
    {
        get => _cAngle;
        set
        {
            var available = 180 - (_aAngle + _bAngle);
            if (value > available)
                throw new Exception("Сумма углов треугольника не может быть больше 180 градусов");
            _cAngle = value;
        }
    }

    public Triangle(double aSide, double bSide, double cSide, double aAngle, double bAngle, double cAngle)
    {
        ASide = aSide;
        BSide = bSide;
        CSide = cSide;
        AAngle = aAngle;
        BAngle = bAngle;
        CAngle = cAngle;
    }

    public double AHeight()
    {
        return GetHeight(_aSide, _bSide, _cSide);
    }

    public double BHeight()
    {
        return GetHeight(_bSide, _aSide, _cSide);
    }

    public double CHeight()
    {
        return GetHeight(_cSide, _aSide, _bSide);
    }

    private double GetHeight(double a, double b, double c)
    {
        var halfMeter = Perimeter() / 2;
        return 2 / a * Math.Sqrt(halfMeter * (halfMeter - a) * (halfMeter - b) * (halfMeter - c));
    }

    public double Perimeter()
    {
        return _aSide + _bSide + _cSide;
    }

    public double Area()
    {
        return 1.0 / 2 * _aSide * _bSide * Math.Sin(_cAngle);
    }

    public string Type()
    {
        if (IsStraightTriangle())
            return "Прямоугольный";
        if (IsEquilateralTriangle())
            return "Равносторонний";
        if (IsIsoscelesTriangle())
            return "Равнобедренный";
        return "Разносторонний";
    }

    private bool IsStraightTriangle()
    {
        var sides = new[] { _aSide, _bSide, _cSide }.ToList();
        sides.Sort();

        return Math.Abs(Math.Pow(sides[2], 2) - (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2))) == 0;
    }

    private bool IsEquilateralTriangle()
    {
        return Math.Abs(_aSide - _bSide) == 0 && Math.Abs(_aSide - _cSide) == 0;
    }

    private bool IsIsoscelesTriangle()
    {
        var angles = new[] { _aAngle, _bAngle, _cAngle }.ToList();
        angles.Sort();
        return Math.Abs(angles[0] - angles[1]) == 0 || Math.Abs(angles[1] - angles[2]) == 0;
    }
}
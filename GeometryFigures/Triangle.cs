namespace GeometryFigures;

public class Triangle : Figure
{
    private double _sideA;
    private double _sideB;
    private double _sideC;
    
    private bool _isRightTriangle;
    private float _calcTolerance = 0.1f;
    
    public double SideA => _sideA;
    public double SideB => _sideB;
    public double SideC => _sideC;
    public bool IsRightTriangle => _isRightTriangle;

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA < 0 | sideB < 0 | sideC < 0)
        {
            throw new ArgumentException("Неправильно указана одна из сторон.");
        }
        
        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
        
        double hypotenuse = Math.Max(_sideA, Math.Max(_sideB, _sideC));
        double perimeter = _sideA + _sideB + _sideC;
        
        if ((perimeter - hypotenuse) - hypotenuse < 1e-7)
            throw new ArgumentException(perimeter + " " + hypotenuse);

        _isRightTriangle = GetIsRightTriangle();
    }

    private bool GetIsRightTriangle()
    {
        double hypotenuse = _sideA, adjacent = _sideB, opposite = _sideC;
        if (adjacent - hypotenuse > 0)
            Utils.Swap(ref hypotenuse, ref adjacent);

        if (opposite - hypotenuse > 0)
            Utils.Swap(ref hypotenuse, ref opposite);

        return Math.Abs(Math.Pow(hypotenuse, 2) - (Math.Pow(adjacent, 2) + Math.Pow(opposite, 2))) < _calcTolerance;
    }

    public override double GetArea()
    {
        double halfPerimeter = (_sideA + _sideB + _sideC) / 2;
        double s = Math.Sqrt(
            halfPerimeter * (halfPerimeter - _sideA) 
                          * (halfPerimeter - _sideB) 
                          * (halfPerimeter - _sideC)
        );
        return s;
    }
}
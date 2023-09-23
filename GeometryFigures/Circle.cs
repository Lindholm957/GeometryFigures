namespace GeometryFigures
{
    public class Circle : Figure
    {
        private double _radius;
        public double Radius => _radius;

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Неправильно указан радиус", nameof(radius));
            _radius = radius;
        }
        
        public override double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
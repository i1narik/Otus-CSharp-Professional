public class Round : Figure
{
    public double Radius { get; }
    public Point Center => Points[0];
    public override double GetPerimetr() => Radius * 2 * Math.PI;
    public Round(double x, double y, double radius)
    {
        Radius = radius;
        Points.Add(new Point { x = x, y = y });
    }
}


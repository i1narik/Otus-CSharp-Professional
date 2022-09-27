public abstract class Figure : IFigure
{
    private List<Point> _points;
    public List<Point> Points => _points;
    public abstract double GetPerimetr();
}

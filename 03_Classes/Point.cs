public struct Point
{
    public double x, y;
    public static Point operator +(Point p1, Point p2)
        => new Point { x = p1.x + p2.x, y = p1.y + p2.y };
}
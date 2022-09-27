public class Vector
{
    internal readonly double x, y;
    public Vector(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public static Vector operator +(Vector a, Vector b) => new Vector(a.x + b.x, a.y + b.y);

    public static double operator *(Vector a, Vector b) => a.x * b.x + a.y * b.y;

    public static Vector operator *(double num, Vector a) => new Vector(a.x * num, a.y * num);

    public static Vector operator *(Vector a, double num) => num * a;

    public override string ToString()
    {
        return $"[{x}, {y}]";
    }
}


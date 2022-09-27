public class Program
{
    public static void Main(string[] args)
    {
        Vector v = new Vector(1, 1);
        Vector v2 = new Vector(2, 2);
        Console.WriteLine(v + v2);
        Console.WriteLine(v * v2);
        Console.WriteLine(v * 5);
        Console.WriteLine(5 * v);
        Console.WriteLine(v2.Length());
    }
}

public static class VectorExtension
{
    public static double Length(this Vector vector) => Math.Sqrt(vector.x * vector.x + vector.y + vector.y);
}

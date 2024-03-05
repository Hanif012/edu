public abstract class Shape
{
    public abstract double CalculateArea();
}

public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        float radius = float.Parse(Console.ReadLine());
        Circle circle = new Circle(radius);
        double area = circle.CalculateArea();
        Console.WriteLine("Area of the circle: " + area);
    }
}

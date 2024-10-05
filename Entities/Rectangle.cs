namespace Classes1OAiP.Entities;

public class Rectangle(double width, double height)
{
    public double Width { get; private set; } = width;
    public double Height { get; private set; } = height;

    public double Area() => Height * Width;

    public double Perimeter() => 2 * (Height + Width);
}
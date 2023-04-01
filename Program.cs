using FactoryPattern;
using FactoryPattern.Interface;

public class Program
{
    public static void Main(String[] args)
    {
        DrawFactory drawFactory = new DrawFactory();
        IShape circle = drawFactory.GetShape("Circle");
        circle.Draw();

        IShape square = drawFactory.GetShape("Square");
        square.Draw();
    }
}
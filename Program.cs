using FactoryPattern;
using FactoryPattern.Interface;

public class Program
{
    public static void Main(String[] args)
    {
        IShape circle = DrawFactory.GetShape("Circle");
        circle.Draw();

        IShape square = DrawFactory.GetShape("Square");
        square.Draw();
    }
}
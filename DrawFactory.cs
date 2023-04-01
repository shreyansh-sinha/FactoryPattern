using FactoryPattern.Interface;
using FactoryPattern.Shapes;

namespace FactoryPattern
{
    public class DrawFactory
    {
        public static IShape? GetShape(string input)
        {
            switch(input)
            {
                case "Circle":
                    return new Circle();
                case "Square":
                    return new Square();
                default:
                    return null;
            }
        }
    }
}

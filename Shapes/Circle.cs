using FactoryPattern.Interface;

namespace FactoryPattern.Shapes
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Circle drawing started");
            Thread.Sleep(1000);
            Console.WriteLine("Circle drawn successfully");
        }
    }
}

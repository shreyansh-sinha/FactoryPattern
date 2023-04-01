using FactoryPattern.Interface;

namespace FactoryPattern.Shapes
{
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Sqaure Drawing started");
            Thread.Sleep(1000);
            Console.WriteLine("Square drawn successfully");
        }
    }
}

namespace LiskovSubstitutionPrinciple
{
    public abstract class Shape
    {
        public abstract double GetArea();
    }
    public class Rectangles : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double GetArea()
        {
            return Width * Height;
        }
        public void ChangeDimensions(Rectangles rect, double width, double height)
        {
            rect.Width = width;
            rect.Height = height;
            Console.WriteLine($"Area: {rect.GetArea()}");
        }
    }
    public class Squares : Shape
    {
        public double Side { get; set; }
        public override double GetArea()
        {
            return Side * Side;
        }
    }
    //Testing the Liskov Substitution Principle
    public class Program
    {
        public static void Main()
        {
            var rect = new Rectangles { Width = 2, Height = 3 };
            rect.GetArea();  // This works fine
            rect.ChangeDimensions(rect, 4, 5);  // This works fine
            var square = new Squares { Side = 2 };
            square.GetArea();  // This also works fine
            // This will not work
            //square.ChangeDimensions(square, 4, 5);  
            Console.ReadKey();
        }
    }
}

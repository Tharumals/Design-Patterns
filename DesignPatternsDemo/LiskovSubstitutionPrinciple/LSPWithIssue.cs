using System.Transactions;

namespace LiskovSubstitutionPrinciple
{
    public class Rectangle
    {
        public virtual double Widht { get; set; }
        public virtual double Height { get; set; }

        public double GetArea()
        {
            return Height * Widht;
        }
    }

    public class Square : Rectangle
    {
        public override double Widht
        {
            get { return base.Widht; }
            set { base.Widht = base.Height = value; }
        }

        public override double Height
        {
            get { return base.Height; }
            set { base.Height = base.Widht = value; }
        }

        public void ChangeDimensions(Rectangle rect, double width, double height)
        {
            rect.Widht = width;
            rect.Height = height;
            Console.WriteLine($"Area: {rect.GetArea()}");
        }

        //public class Program
        //{
        //    public static void Main()
        //    {
        //        var rect = new Rectangle { Widht = 2, Height = 3 };
        //       // rect.ChangeDimensions(rect, 4, 5);  // This works fine
        //        var square = new Square { Widht = 2 };
        //       // rect.ChangeDimensions(square, 4, 5);  // This behaves unexpectedly!
        //        Console.ReadKey();
        //    }
        //}

    }
}

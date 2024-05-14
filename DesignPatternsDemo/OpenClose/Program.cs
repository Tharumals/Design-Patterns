namespace OpenClose
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var regularDiscount = new RegularDiscount();
            var calculater =new DiscountCalculator(regularDiscount);

            var discount = calculater.CalculateDiscount(100);

            Console.WriteLine(discount);

        }
    }
}
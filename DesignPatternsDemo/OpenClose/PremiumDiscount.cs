namespace OpenClose
{
    public class PremiumDiscount : IDiscountStrategy
    {
        public double CalculateDiscount(double price)
        {
            return price * 0.3;
        }
    }
}

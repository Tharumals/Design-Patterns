namespace OpenClose
{
    public class DiscountCalculator
    {
        private readonly IDiscountStrategy _discountStrategy;

        public DiscountCalculator( IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy; 
        }

        public double CalculateDiscount(double price)
        {
            return _discountStrategy.CalculateDiscount(price);
        }
    }
}

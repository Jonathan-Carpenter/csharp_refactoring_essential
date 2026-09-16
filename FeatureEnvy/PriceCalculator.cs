namespace FeatureEnvy;

public class PriceCalculator
{
    public double CalculateFinalPrice(Product product)
    {
        return product.GetFinalPrice();
    }
}
namespace FeatureEnvy;

public class Product
{
    private readonly double price;
    private readonly bool onSale;

    public Product(double price, bool onSale)
    {
        this.price = price;
        this.onSale = onSale;
    }

    public double GetFinalPrice()
    {
        double finalPrice = this.price;

        if (this.onSale)
        {
            finalPrice = finalPrice * 0.8;
        }

        return finalPrice;
    }
}
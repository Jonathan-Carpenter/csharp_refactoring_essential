using LegacyCode;

namespace ShippingCalculator.Test
{
    public class ShippingCalculatorTests
    {
        private LegacyCode.ShippingCalculator shippingCalculator = new(new DummyOrderService(new Order()
        {
            DistanceKm = 0.0,
            Fragile = false,
            OrderId = 0,
            ShippingType = "STANDARD",
            WeightKg = 5
        }));

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var shipping = this.shippingCalculator.CalculateShipping(0);

            Assert.That(shipping, Is.EqualTo(2.5));
        }
    }
}

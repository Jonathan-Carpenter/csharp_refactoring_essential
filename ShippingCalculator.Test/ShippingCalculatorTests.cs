using LegacyCode;

namespace ShippingCalculator.Test
{
    public class ShippingCalculatorTests
    {
        private static IEnumerable<TestCaseData> TestCases
        {
            get
            {
                yield return new TestCaseData(
                    new Order
                    {
                        DistanceKm = 0.0,
                        Fragile = false,
                        OrderId = 0,
                        ShippingType = "STANDARD",
                        WeightKg = 5
                    },
                    2.5);
            }
        }

        [Test]
        [TestCaseSource(nameof(TestCases))]
        public void Test1(Order order, double expectedShippingCost)
        {
            var shippingCalculator = new LegacyCode.ShippingCalculator(new DummyOrderService(order));

            var shipping = shippingCalculator.CalculateShipping(0);

            Assert.That(shipping, Is.EqualTo(2.5));
        }
    }
}

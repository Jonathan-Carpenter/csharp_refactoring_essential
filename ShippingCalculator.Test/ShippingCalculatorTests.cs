using LegacyCode;

namespace ShippingCalculator.Test
{
    public class ShippingCalculatorTests
    {
        private static IEnumerable<TestCaseData> TestCases
        {
            get
            {
                // 5kg * 0.5 = 2.5
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

                // (5kg * 0.8) + (3km * 0.1) = 4 + 0.3 = 4.3
                yield return new TestCaseData(
                    new Order
                    {
                        DistanceKm = 3.0,
                        Fragile = false,
                        OrderId = 0,
                        ShippingType = "EXPRESS",
                        WeightKg = 5
                    },
                    4.3);

                // (5kg * 1.2) + 25 = 31
                yield return new TestCaseData(
                    new Order
                    {
                        DistanceKm = 0.0,
                        Fragile = false,
                        OrderId = 0,
                        ShippingType = "OVERNIGHT",
                        WeightKg = 5
                    },
                    31);
            }
        }

        [Test]
        [TestCaseSource(nameof(TestCases))]
        public void Test1(Order order, double expectedShippingCost)
        {
            var shippingCalculator = new LegacyCode.ShippingCalculator(new DummyOrderService(order));

            var shipping = shippingCalculator.CalculateShipping(0);

            Assert.That(shipping, Is.EqualTo(expectedShippingCost));
        }
    }
}

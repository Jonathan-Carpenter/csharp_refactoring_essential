namespace Comments.Test;

using NUnit.Framework;

[TestFixture]
public class CalculatorTest
{
    [Test]
    public void CalculatingSumOfSquaresInRange()
    {
        int lowerBound = 7;
        int upperBound = 12;

        int expectedSum = 0;
        for (int i = lowerBound; i <= upperBound; i++)
        {
            expectedSum += i * i;
        }

        int actualResult = Calculator.SumOfSquaresInRange(lowerBound, upperBound);

        Assert.That(actualResult, Is.EqualTo(expectedSum));
    }
}
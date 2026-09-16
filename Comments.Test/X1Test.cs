namespace Comments.Test;

using NUnit.Framework;

[TestFixture]
public class X1Test
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

        int actualResult = X1.SumOfSquaresInRange(lowerBound, upperBound);

        Assert.That(actualResult, Is.EqualTo(expectedSum));
    }
}
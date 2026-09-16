namespace Comments;

public class Calculator
{
    public static int SumOfSquaresInRange(int lowerBound, int upperBound)
    {
        int sumOfSquares = 0;

        for (int i = lowerBound; i <= upperBound; i++)
        {
            sumOfSquares += i*i;
        }

        return sumOfSquares;
    }
}
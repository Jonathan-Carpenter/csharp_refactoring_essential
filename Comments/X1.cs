namespace Comments;

public class X1
{
    public static int M(int lowerBound, int upperBound)
    {
        int sumOfSquares = 0;

        for (int i = lowerBound; i <= upperBound; i++)
        {
            // Add square of each number in the range
            sumOfSquares += N(i);
        }

        return sumOfSquares;
    }

    static int N(int k)
    {
        // Return square of input
        return k * k;
    }
}
namespace Comments;

public class X1
{
    public static int M(int lowerBound, int upperBound)
    {
        int sumOfSquares = 0;

        for (int i = lowerBound; i <= upperBound; i++)
        {
            sumOfSquares += i*i;
        }

        return sumOfSquares;
    }
}
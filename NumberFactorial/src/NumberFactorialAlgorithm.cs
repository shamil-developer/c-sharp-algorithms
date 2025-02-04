namespace NumberFactorial;

public class NumberFactorialAlgorithm
{
    public static int CalculateFactorialWithRecursion(int input)
    {
        if (input == 1)
        {
            return 1;
        }
        return input * CalculateFactorialWithRecursion(input - 1);
    }

    public static int CalculateFactorial(int n)
    {
        int result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}

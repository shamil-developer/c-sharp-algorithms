namespace SelectionSort;

public class SumByRecursionAlgorithm
{
    int Sum(int[] array)
    {
        if (array.Length == 0)
        {
            return 0;
        }

        return array[^1] + Sum(array[..^1]);
    }
}

namespace SelectionSort;

public class SelectionSortAlgorithm
{
    public static int[] SelectionSort(ref int[] array)
    {
        for (var i = 0; i < array.Length; i++)
        {
            var smallestIndex = i;

            for (var index = i + 1; index < array.Length; index++)
            {
                if (array[index] < array[smallestIndex])
                {
                    smallestIndex = index;
                }
            }
            (array[i], array[smallestIndex]) = (array[smallestIndex], array[i]);
        }

        return array;
    }
}

namespace QuickSort;

public static class QuickSortAlgorithm
{
    public static void QuickSort(this int[] array)
    {
        QuickSort(array, 0, array.Length - 1);
    }
    private static void QuickSort(int[] array, int l, int r)
    {
        if (l < r)
        {
            int pivot = Partition(array, l, r);

            QuickSort(array, l, pivot - 1);
            QuickSort(array, pivot + 1, r);
        }
    }

    private static int Partition(int[] arr, int left, int right)
    {
        int pivot = arr[right];
        int i = left - 1;
        for (int j = left; j < right; j++)
        {
            if (arr[j] <= pivot)
            {
                i++;
                (arr[j], arr[i]) = (arr[i], arr[j]);
            }
        }
        (arr[right], arr[i + 1]) = (arr[i + 1], arr[right]);
        return i + 1;
    }
}

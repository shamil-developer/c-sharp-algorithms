public static class BinarySearch
{
    public static int Search(in IReadOnlyCollection<int> input, int searched)
    {
        var array = input.ToArray();

        var low = 0;
        var high = array.Length;

        while (low <= high)
        {
            var mid = (low + high) / 2;
            var guess = array[mid];

            if (guess == searched)
            {
                return mid;
            }

            if (guess < searched)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        throw new ArgumentException();
    }
}
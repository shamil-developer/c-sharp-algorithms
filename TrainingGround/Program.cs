Console.WriteLine("START");

var array = new int[] {5,2,8,1,9,3};

 Algo. QuickSort(array);

Console.WriteLine(string.join(',',array));
Console.WriteLine();

Console.WriteLine("END");

static class Algo
{
	public static void QuickSort(int[] array)
	{
		QuickSort(array, 0, array.Length - 1); 
	}
	private static void QuickSort(int[] array, int leftIndex, int rightIndex)
	{
		if(leftIndex < rightIndex) 
		{
			var pivot = Partition(array, leftIndex, rightIndex);

			QuickSort(array, leftIndex, pivot - 1);
			QuickSort(array, pivot + 1, rightIndex);
		}
	}
	private static int Partition(int[] array, int leftIndex, int rightIndex)
	{
		var pivot = array[rightIndex];
		var i = leftIndex - 1;
		for(var j = leftIndex; j < array.Length; j++)
		{
			if(array[j] < pivot)
			{
				i++;
				(array[j], array[i]) = (array[i], array[j]);
			}
		}
		(array[rightIndex], array[i]) = (array[i], array[rightIndex]);

		retrun i + 1;
	}
}
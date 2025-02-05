
Console.WriteLine("START");

var array = new int[] { 1,3,4,6,7,8,9 };

var res = Algo. BinarySearch(array,9);

Console.WriteLine();
Console.WriteLine(res);
Console.WriteLine();

Console.WriteLine("END");

class Algo
{
	public static int BinarySearch(int[] array, int searched)
	{
		var low = 0;
		var high = array.Length;

		while(low <= high)
		{
			var mid = (low + high) / 2;

			var guess = array[mid];

			if(guess == searched)
			{
				return mid;
			}

			if(guess < searched)
			{
				low = mid + 1;
			}
			else
			{
				high = mid - 1;
			}
		}

		throw new Exception();
	}
}

Console.WriteLine("START");

var array = new int[] { 1,2,4,6,8,9,15 };

var index = Algo.BinarySearch(ref array,15);

Console.WriteLine();
Console.WriteLine(index);
Console.WriteLine();

Console.WriteLine("END");

class Algo
{
	public static int BinarySearch(ref int[] array,int searched)
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

		throw new ArgumentException();
	}
}
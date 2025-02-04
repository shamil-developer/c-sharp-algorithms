
Console.WriteLine("START");

var array = new int[] { 2,3,6,8,9,13,18,45 };

var res =Algo.BinarySearch(array,19);

Console.WriteLine();
Console.WriteLine(res);
Console.WriteLine();

Console.WriteLine("END");

class Algo
{
	public static int BinarySearch(in int[] array, int input)
	{
		var low = 0;
		var high = array.Length;

		while(low <= high)
		{
			var mid = (low + high) / 2;

			var guess = array[mid];

			if(guess == input)
			{
				return mid;
			}

			if(guess < input)
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
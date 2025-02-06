
Console.WriteLine("START");

var array = new int[] { 0, 1,3,5,7,8,9 };

 var res= Algo. BinarySearch(array,7);

Console.WriteLine(res);
Console.WriteLine(string.Join(',',array));
Console.WriteLine();

Console.WriteLine("END");

static class Algo
{
	public static  int BinarySearch(int[] array, int input)
	{
		var low = 0;
		var high = array.Length;

		while(low <=high)
		{
			var mid = (low + high) / 2;
			var guess = array[mid];

			if(input == guess)
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

		throw new Exception("2222222222");
	}
}
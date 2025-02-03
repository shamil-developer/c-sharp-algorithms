Console.WriteLine("Hello");

var randomArray = new int[] { 15, 18, 23, 27, 34, 39, 42, 45, 56, 58, 60, 61, 67, 73, 78, 82, 89, 90, 94, 97 };

var res = BinarySearch(randomArray, 97);

Console.WriteLine(res);

int BinarySearch(in IReadOnlyCollection<int> input,in int searched)
{
var 
    var array = input.ToArray();
    var low = 0;
    var high = array.Length;

    while(low <= high)
    {
        var middle = (low + high) / 2;
        
        var guess = array[middle];

        if(guess == searched)
        {
            return middle;
        }

        if(guess < searched)
        {
            low = middle + 1;
        }
        else
        {
            high = middle - 1; 
        }
    }

    throw new ArgumentException();
}
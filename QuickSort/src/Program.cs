Console.WriteLine("START");

var array = new int[] { 0, 17, 34, 50, 66, 83, 12, 49, 75, 26, 98, 3, 19, 56, 72, 8, 41, 63, 91, 2, 23, 45, 68, 86, 15, 53, 79, 30, 94 };

QuickSort.QuickSortAlgorithm.QuickSort(array);

Console.WriteLine("END");
Console.WriteLine();
Console.WriteLine(string.Join(",", array));

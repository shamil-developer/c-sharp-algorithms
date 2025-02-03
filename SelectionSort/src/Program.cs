// See https://aka.ms/new-console-template for more information
using SelectionSort;

Console.WriteLine("START");

var array = new int[] { 10, 96, 98, 64, 34, 30, 22, 46, 3, 87, 16, 91, 67, 66, 18, 93, 48, 84, 65 };

SelectionSortAlgorithm.SelectionSort(ref array);

Console.WriteLine("END");

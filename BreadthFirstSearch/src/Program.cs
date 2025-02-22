// See https://aka.ms/new-console-template for more information
using BreadthFirstSearch;

Console.WriteLine("START");

var graph = new Dictionary<string, string[]>(){
    {"lvl_1_A", ["lvl_2_A","lvl_2_B","lvl_2_C"]},
    {"lvl_2_A", ["lvl_1_A"]},
    {"lvl_2_B", []},
    {"lvl_2_C", ["lvl_3_A"]},
    {"lvl_3_A", []},
};

var searched = BreadthFirstSearchAlgorithm.Search(graph, "lvl_1_A", "lvl_1_A");

Console.WriteLine($"Searched {searched}");

Console.WriteLine("END");
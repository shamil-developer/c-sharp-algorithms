№ ПОИСК В ШИРИНУ

- `breadth-first search`
- `BFS`
- `BreadthFirstSearch`

### Этапы алгоритма:

1. Создаем очередь
2. Добавляем в очередь элемент с какого начнем поиски
3. Создаем список для тех ребер которые посетили
4. Начинаем цикл
5. Берем из очереди
6. 🎉🎉🎉 Если он подходит то завершаем поиск 🎉🎉🎉
7. Если не подошел то:
   1. Добавим его к посещенным
   2. Добавим его соседей в очередь
   3. Продолжается цикл до удовлетворительного результата

### Оценки сложности алгоритма:

```math
O(V+E)
```

- `V` количество вершин
- `E` количество ребер

### Код на языке c#

```c#
var graph = new Dictionary<string, string[]>(){
    {"lvl_1_A", ["lvl_2_A","lvl_2_B","lvl_2_C"]},
    {"lvl_2_A", ["lvl_1_A"]},
    {"lvl_2_B", []},
    {"lvl_2_C", ["lvl_3_A"]},
    {"lvl_3_A", []},
};

var queue = new Queue<string>();

queue.Enqueue("lvl_1_A");
var visited = new HashSet<string>();
while (queue.Count > 0)
{
    var current = queue.Dequeue();
    if (visited.Contains(current)) { continue; }
    if (current == "lvl_3_A") { Console.WriteLine("FINISH"); break; }
    visited.Add(current);
    foreach (var item in graph[current]) { queue.Enqueue(item); }
}
```

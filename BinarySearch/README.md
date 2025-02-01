# БИНАРНЫЙ ПОИСК

## Оценки сложности алгоритма:

$$
O (log\ n)
$$

## Шаги:

1. Сортировка массива данных:
   - Убедитесь, что массив данных уже отсортирован по возрастанию.
2. Деление массива пополам:
   - Найдите середину массива.
3. Сравнение с искомым элементом:
4. Сравните срединный элемент с заданным искомым элементом.
5. Если искомое число больше среднего, продолжайте поиск в правой части массива.

## Код на языке c#

```c#
///<summary>Бинарный поиск</summary>
///<remarks>O(log\ n)</remarks>
static int BinarySearch(in IReadOnlyCollection<int> input, int searched)
{
    var array = input.ToArray();

    var low = 0;
    var high = array.Length;

    while (low <= high)
    {
        var mid = (low + high) / 2;
        var guess = array[mid];

        if (guess == searched)
        {
            return mid;
        }

        if (guess < searched)
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
```

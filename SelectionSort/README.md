# СОРТИРОВКА ВЫБОРОМ

**_Сортировка выбором_** — это простой и интуитивно понятный алгоритм сортировки

### Этапы алгоритма:

1. Поиск минимального элемента:
   - Проходим по массиву и находим минимальный элемент.
2. Обмен:
   - Меняем найденный минимальный элемент с первым элементом неотсортированной части массива.
3. Рекурсия:
   - Повторяем шаги 2 и 3 для оставшихся неотсортированных элементов.

### Оценки сложности алгоритма:

$$
O(n²)
$$

### Код на языке c#

```c#
public static int[] SelectionSort(int[] array)
{
    for (var i = 0; i < array.Length; i++)
    {
        var smallestIndex = i;

        for (var index = i + 1; index < array.Length; index++)
        {
            if (array[index] < array[smallestIndex])
            {
                smallestIndex = index;
            }
        }
        (array[i], array[smallestIndex]) = (array[smallestIndex], array[i]);
    }

    return array;
}
```

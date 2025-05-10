(int[], int[]) makePair(int[] array1, int[] array2)
{
    int[] largestArray;
    int[] smallestArray;
    if (array1.Length > array2.Length)
    {
        largestArray = array1;
        smallestArray = array2;
    }
    else
    {
        largestArray = array2;
        smallestArray = array1;
    }
    return (smallestArray, largestArray);
}

Dictionary<int, bool> makeDictionaryAsIndex(int[] intArray)
{
    Dictionary<int, bool> map = new Dictionary<int, bool>();
    foreach (var item in intArray)
    {
        map.Add(item, true);
    }
    return map;
}

// пересечение двух массивов
int[] intersect(int[] array1, int[] array2)
{
    // вычисление самого длинного массива и короткого
    var pair = makePair(array1, array2);
    int[] smallestArray = pair.Item1;
    int[] largestArray = pair.Item2;

    // создание словаря (хеш-таблицы в качестве индекса)
    Dictionary<int, bool> map = makeDictionaryAsIndex(smallestArray);

    // создание массива из элементов пересечения
    int[] result = new int[] { };
    foreach (var item in largestArray)
    {
        if (map.ContainsKey(item))
        {
            Array.Resize(ref result, result.Length + 1);
            result[result.GetUpperBound(0)] = item;
        }
    }
    return result;
}

void main()
{
    int[] array1 = { 1, 2, 3, 4, 5 };
    int[] array2 = { 0, 2, 4, 6, 8 };

    intersect(array1, array2).ToList().ForEach(i => Console.WriteLine(i.ToString()));
}

main();

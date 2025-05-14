// реализация O(N2)
int findLargestNumberN2(int[] numbers)
{
    int max = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        for (int j = i + 1; j < numbers.Length; j++)
        {
            if (numbers[i] < numbers[j])
            {
                if (numbers[j] > max)
                {
                    max = numbers[j];
                }
            }
        }
    }
    return max;
}

// реализация O(NlogN)
int findLargestNumberNlogN(int[] numbers)
{
    int[] copyArray = new int[numbers.Length];
    System.Array.Copy(numbers, copyArray, numbers.Length);
    System.Array.Sort(copyArray);

    return copyArray[copyArray.Length - 1];
}

// реализация O(N)
int findLargestNumberN(int[] numbers)
{
    int max = numbers[0];
    foreach (var item in numbers)
    {
        if (item > max)
        {
            max = item;
        }
    }
    return max;
}

Console.WriteLine(findLargestNumberN2(new int[] { 1, 2, 3 }));

Console.WriteLine(findLargestNumberNlogN(new int[] { 1, 2, 3 }));

Console.WriteLine(findLargestNumberN(new int[] { 1, 2, 3 }));

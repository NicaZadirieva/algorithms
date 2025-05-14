Nullable<int> findMissingNumber(int[] array)
{
    for (var i = 0; i < array.Length; i++)
    {
        if (Array.IndexOf(array, array[i]) >= 0)
        {
            return i;
        }
    }
    return null;
}

Console.WriteLine(findMissingNumber(new int[] { 1, 2, 3 }));

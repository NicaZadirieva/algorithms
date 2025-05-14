Nullable<int> findMissingNumber(int[] array)
{
    int[] copyArray = new int[array.Length];
    System.Array.Copy(array, copyArray, array.Length);
    System.Array.Sort(copyArray);

    for (var i = 0; i < copyArray.Length; i++)
    {
        if (copyArray[i] != i)
        {
            return i;
        }
    }
    return null;
}

Console.WriteLine(findMissingNumber(new int[] { 1, 2, 3 }));

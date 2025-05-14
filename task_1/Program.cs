int getLargestProduct(int[] numbers)
{
    if (numbers.Length > 2)
    {
        int[] numbersCopy = new int[numbers.Length];
        System.Array.Copy(numbers, numbersCopy, numbers.Length);
        System.Array.Sort(numbersCopy);
        return numbersCopy[numbersCopy.Length - 1]
            * numbersCopy[numbersCopy.Length - 2]
            * numbersCopy[numbersCopy.Length - 3];
    }
    return 0;
}
int[] numbers = new int[] { 1, 2, 3, 4, 5, 1 };
Console.WriteLine(getLargestProduct(numbers));

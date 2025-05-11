List<int> getOnlyEvenNumbers(int index, List<int> numbers, List<int> result)
{
    if (numbers.Count == index)
    {
        return result;
    }
    if (numbers[index] % 2 == 0)
    {
        result.Add(numbers[index]);
    }
    return getOnlyEvenNumbers(index + 1, numbers, result);
}

void main()
{
    List<int> numbers = new List<int>([1, 2, 4, 5, 6, 10]);
    var evenNumbers = getOnlyEvenNumbers(0, numbers, new List<int>());
    foreach (var item in evenNumbers)
    {
        Console.WriteLine(item);
        Console.WriteLine(" ");
    }
}

main();

List<int> getOnlyEvenNumbers(List<int> numbers, List<int> result, int index = 0)
{
    if (numbers.Count == index)
    {
        return result;
    }
    if (numbers[index] % 2 == 0)
    {
        result.Add(numbers[index]);
    }
    return getOnlyEvenNumbers(numbers, result, index + 1);
}

void main()
{
    List<int> numbers = new List<int>([1, 2, 4, 5, 6, 10]);
    var evenNumbers = getOnlyEvenNumbers(numbers, new List<int>());
    foreach (var item in evenNumbers)
    {
        Console.WriteLine(item);
        Console.WriteLine(" ");
    }
}

main();

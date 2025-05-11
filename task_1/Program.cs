// возвращает количество букв во всех словах в массиве
int getSummaryCount(string[] words)
{
    if (words.Length == 0)
    {
        return 0;
    }
    return words.Length + getSummaryCount(words.AsSpan(1, words.Length - 1).ToArray());
}

void main()
{
    string[] words = { "ab", "c", "def", "ghij" };
    Console.WriteLine(getSummaryCount(words));
}

main();

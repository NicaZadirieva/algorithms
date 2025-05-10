Dictionary<char, int> makeCounterDictionary(char[] charArray)
{
    Dictionary<char, int> map = new Dictionary<char, int>();
    foreach (var item in charArray)
    {
        if (!Char.IsLetter(item))
        {
            continue;
        }
        if (map.ContainsKey(item))
        {
            map[item] = map[item] + 1;
        }
        else
        {
            map.Add(item, 1);
        }
    }
    return map;
}

// возвращает первую неповторяющуюся букву в слове
Nullable<char> getLetterNotDuplicatedAt(string word)
{
    var arrayFromWord = word.ToCharArray();

    var dictionary = makeCounterDictionary(arrayFromWord);
    foreach (var item in arrayFromWord)
    {
        if (dictionary[item] == 1)
        {
            return item;
        }
    }
    return null;
}

void main()
{
    string word = "minimum";
    Console.WriteLine(getLetterNotDuplicatedAt(word));
}

main();

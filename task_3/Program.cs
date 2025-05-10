char[] ALPHABET = new char[]
{
    'a',
    'b',
    'c',
    'd',
    'e',
    'f',
    'g',
    'h',
    'i',
    'j',
    'k',
    'l',
    'm',
    'n',
    'o',
    'p',
    'q',
    'r',
    's',
    't',
    'u',
    'v',
    'w',
    'x',
    'y',
    'z',
};
Dictionary<char, bool> makeDictionaryAsIndex(char[] intArray)
{
    Dictionary<char, bool> map = new Dictionary<char, bool>();
    foreach (var item in intArray)
    {
        if (!map.ContainsKey(item))
        {
            map.Add(item, true);
        }
    }
    return map;
}

// возвращает букву, которой нет в слове
Nullable<char> getLetterNotExistedAt(string word)
{
    var arrayFromWord = word.ToCharArray();

    var dictionary = makeDictionaryAsIndex(arrayFromWord);
    foreach (var item in ALPHABET)
    {
        if (!dictionary.ContainsKey(item))
        {
            return item;
        }
    }
    return null;
}

void main()
{
    string testWord = "the quick brown box jumps over a lazy dog";
    Console.WriteLine(getLetterNotExistedAt(testWord));
}
main();

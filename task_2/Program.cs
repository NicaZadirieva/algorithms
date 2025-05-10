Dictionary<string, int> makeCounterDictionary(string[] strArray)
{
    Dictionary<string, int> map = new Dictionary<string, int>();
    foreach (var item in strArray)
    {
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

// вернет первое повторяющееся значение
string getFirstDuplicatedElem(string[] list)
{
    var dictionary = makeCounterDictionary(list);
    foreach (var item in list)
    {
        if (dictionary[item] > 1)
        {
            return item;
        }
    }
    return null;
}

void main()
{
    var list = new string[] { "a", "b", "c", "d", "c", "e", "f" };
    Console.WriteLine("Первое повторяющееся значение = " + getFirstDuplicatedElem(list));
}
main();

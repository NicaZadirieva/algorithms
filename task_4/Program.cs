// обращение строки через стек
string reserved(string word)
{
    string reserved = "";
    Stack<char> lettersStack = new Stack<char>(word.ToCharArray());
    foreach (var item in lettersStack)
    {
        reserved += item.ToString();
    }
    return reserved;
}

void main()
{
    string word = "abcde";
    Console.WriteLine(reserved(word));
}

main();

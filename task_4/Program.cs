using System.Text;

// обращение строки через стек
string reserved(string word)
{
    StringBuilder reserved = new StringBuilder();
    Stack<char> lettersStack = new Stack<char>(word.ToCharArray());
    foreach (var item in lettersStack)
    {
        reserved.Append(item.ToString());
    }
    return reserved.ToString();
}

void main()
{
    string word = "abcde";
    Console.WriteLine(reserved(word));
}

main();

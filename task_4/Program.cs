// возвращает индекс первого 'x' в строке
int getIndexOfFirstX(string word, int foundAtIndex = 0)
{
    if (word[foundAtIndex] == 'x')
    {
        return foundAtIndex;
    }
    else
    {
        return getIndexOfFirstX(word, foundAtIndex + 1);
    }
}

void main()
{
    string word = "abcdefghijklmnopqrstuvwxyz";
    Console.WriteLine(getIndexOfFirstX(word));
}

main();

int calcShortestPaths(int X, int Y)
{
    if (X == 0 && Y == 0)
    {
        return 1;
    }
    if (X < 0 || Y < 0)
    {
        return 0;
    }

    return calcShortestPaths(X - 1, Y) + calcShortestPaths(X, Y - 1);
}

void main()
{
    Console.WriteLine(calcShortestPaths(3, 7));
}
main();

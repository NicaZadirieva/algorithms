int calcShortestPaths(int X, int Y, int tempX = 0, int tempY = 0)
{
    if (tempX == X && tempY == Y)
    {
        return 1;
    }
    if (tempX > X || tempY > Y)
    {
        return 0;
    }
    return calcShortestPaths(X, Y, tempX + 1, tempY) + calcShortestPaths(X, Y, tempX, tempY + 1);
}

void main()
{
    Console.WriteLine(calcShortestPaths(3, 7));
}
main();

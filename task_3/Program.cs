// вычисление треугольных чисел
int getNTriangularNumber(int N)
{
    if (N == 1)
    {
        return 1;
    }
    return N + getNTriangularNumber(N - 1);
}

void main()
{
    Console.WriteLine(getNTriangularNumber(7));
}

main();

// найти индекс самого большого элемента в масиве
int greatestNumber(float[] array)
{
    int foundAtIndex = 0;
    float foundMaxElement = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > foundMaxElement)
        {
            foundAtIndex = i;
            foundMaxElement = array[i];
        }
    }
    return foundAtIndex;
}

void main()
{
    float[] array = new float[] { 0, 5, 9, 1000 };
    Console.WriteLine(
        "Самое большое число в массиве находится под индексом = " + greatestNumber(array)
    );
}

main();
